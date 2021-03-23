using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;
using System.Collections.Generic;
using System.Web;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;




namespace Bioscoop.Models
{
    public class PdfGenerator
    {


        IConverter _converter;
        public PdfGenerator(IConverter converter)
        {
            _converter = converter;
        }

        public Byte[] CreatePDF(String html , PechkinPaperSize papersize){


         var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = papersize,
                Margins = new MarginSettings { Top = 0 ,Bottom=0 ,Left=0,Right=0},                
                DocumentTitle = "PDF Report"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = html,
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet =  "wwwroot/assets/dist/css/bootstrap.min.css" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

           var file = _converter.Convert(pdf);
           
        return  file;
        }

        public String getHTML(String url)
        {
            WebRequest objRequest = System.Net.HttpWebRequest.Create(url);
            StreamReader sr = new StreamReader(objRequest.GetResponse().GetResponseStream());
            string result = sr.ReadToEnd();
            sr.Close();
            return result;
        }

    }

}