using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class XXE : Controller
{
    public IActionResult Index(bool isCorrect)
    {
        return View(isCorrect ? "Correct" : "Incorrect");
    }

    [HttpPost]
    public IActionResult LoadXml(string xml, bool safe = false)
    {
        try
        {
            var settings = new System.Xml.XmlReaderSettings();
            settings.DtdProcessing = System.Xml.DtdProcessing.Parse;
            if (!safe)
                settings.XmlResolver = new System.Xml.XmlUrlResolver();
            
            var reader = System.Xml.XmlReader.Create(new System.IO.StringReader(xml), settings);
            var doc = new System.Xml.XmlDocument();
            doc.Load(reader);

            var stringWriter = new StringWriter();
            var xmlTextWriter = new System.Xml.XmlTextWriter(stringWriter)
            {
                Formatting = System.Xml.Formatting.Indented
            };
            doc.WriteTo(xmlTextWriter);

            return Content(stringWriter.ToString(), "application/xml");
        }
        catch (Exception ex)
        {
            return Content(ex.Message);
        }
    }
}