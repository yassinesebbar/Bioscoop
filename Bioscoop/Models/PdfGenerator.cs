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

        public Byte[] CreatePDF(String html){


         var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A6,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = html,
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet =  "wwwroot/assets/dist/css/bootstrap.min.css" },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
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