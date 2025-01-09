using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace ImproperInputValidation.Controllers;

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
            var settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse
            };
            if (!safe)
                settings.XmlResolver = new XmlUrlResolver();

            var reader = XmlReader.Create(new StringReader(xml), settings);
            var doc = new XmlDocument();
            doc.Load(reader);

            var stringWriter = new StringWriter();
            var xmlTextWriter = new XmlTextWriter(stringWriter)
            {
                Formatting = Formatting.Indented
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