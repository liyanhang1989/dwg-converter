using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwg_converter
{
    public class ExportToPDF
    {
        public static void Run()
        {
            //ExStart:ExportToPDF
            // The path to the documents directory.
            string MyDir = Directory.GetCurrentDirectory();
            string sourceFilePath = MyDir + "\\dwg-files\\Bottom_plate.dwg";
            using (Aspose.CAD.Image image = Aspose.CAD.Image.Load(sourceFilePath))
            {
                // Create an instance of CadRasterizationOptions and set its various properties
                Aspose.CAD.ImageOptions.CadRasterizationOptions rasterizationOptions = new Aspose.CAD.ImageOptions.CadRasterizationOptions();
                rasterizationOptions.BackgroundColor = Aspose.CAD.Color.White;
                rasterizationOptions.PageWidth = 1600;
                rasterizationOptions.PageHeight = 1600;

                // Create an instance of PdfOptions
                Aspose.CAD.ImageOptions.PdfOptions pdfOptions = new Aspose.CAD.ImageOptions.PdfOptions();
                // Set the VectorRasterizationOptions property
                pdfOptions.VectorRasterizationOptions = rasterizationOptions;

                MyDir = MyDir + "Bottom_plate_out.pdf";
                // Export the DWG to PDF
                image.Save(MyDir, pdfOptions);
            }
            //ExEnd:ExportToPDF            
            Console.WriteLine("\nThe DWG file exported successfully to PDF.\nFile saved at " + MyDir);

        }
    }
}
