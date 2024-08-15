using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace AppIExternalApplication
{
    public class Class1 : IExternalApplication
    {
        public ContextualHelp ContextualHelp { get; private set; }

        public Result OnShutdown(UIControlledApplication application)
        {

            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            //Crear Pestaña
            application.CreateRibbonTab("Tab01");

            //Crear paneles dentro de pestaña personalizada
            RibbonPanel panelDePestaña = application.CreateRibbonPanel("Tab01", "Panel001");
         
            //Crear un pushButton

            PushButtonData datosDelPushButton = new PushButtonData("Boton01","Boton001", typeof(Class1).Assembly.Location, "AppIExternalApplication.Class2");

            //Colocando Push Button dentro del panel

            PushButton pushButton =  panelDePestaña.AddItem(datosDelPushButton) as PushButton;

            //Colocando Propiedades

            pushButton.ToolTip = "Esta sera la descripcion corta del Push Button";
            pushButton.LongDescription = "Esta sera la descripcion larga del Push Button";
            pushButton.ToolTipImage = ConvertImage(Properties.Resources.Captura);

            ContextualHelp ayudaContextual = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            pushButton.SetContextualHelp(ayudaContextual);
            pushButton.LargeImage = ConvertImage(Properties.Resources.aterrizaImg2);

            panelDePestaña.AddSeparator();

            return Result.Succeeded;
        }

        private System.Windows.Media.ImageSource ConvertImage(System.Drawing.Image image)
        {
            var bitmap = new System.Windows.Media.Imaging.BitmapImage();
            bitmap.BeginInit();
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            bitmap.StreamSource = memoryStream;
            bitmap.EndInit();
            return bitmap;
        }


    }
}
