using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLIOTECA.CAMADAS.MODEL;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.Style;
using Spire.Xls;
//using Excel = Microsoft.Office.Interop.Excel;


namespace BIBLIOTECA.RELATORIOS
{
    public partial class frmRelEmp : Form
    {
        public frmRelEmp()
        {
            InitializeComponent();
        }

        private void btnRel1_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Itens bllItem = new CAMADAS.BLL.Itens();
            List<CAMADAS.MODEL.Itens> lstItens = new List<CAMADAS.MODEL.Itens>();
            lstItens = bllItem.Select();


            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelItens_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".xlsx";
            string arquivoPDF = pasta + @"\RelItens_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".pdf";

            FileInfo caminhoNomeArquivo = new FileInfo(arquivo);
            ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add("Plan1");
                        

            int col = 1;
            int lin = 1;
            planilha.Cells[lin, col].Value = "ID";
            planilha.Cells[lin, ++col].Value = "EMPRÉSTIMO";
            planilha.Cells[lin, ++col].Value = "TÍTULO";
            planilha.Cells[lin, ++col].Value = "ENTREGA";

            foreach (CAMADAS.MODEL.Itens item in lstItens)
            {
                col = 1;
                planilha.Cells[++lin, col].Value = item.id;
                planilha.Cells[lin, ++col].Value = item.emprestimoID;
                planilha.Cells[lin, ++col].Value = item.titulo;
                planilha.Cells[lin, ++col].Value = item.entrega;
                planilha.Cells[lin, col].Style.Numberformat.Format = "dd-MM-yyyy";

            }

            ExcelRange rng;

            using (rng = planilha.Cells["A1:D1"])
            {
                rng.Style.Font.Size = 15;
                rng.Style.Font.Name = "Arial";
                rng.Style.Font.Bold = true;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                rng.Style.Fill.BackgroundColor.SetColor(Color.Gray);
                rng.Style.Font.Color.SetColor(Color.White);
            }

            using (rng = planilha.Cells["A2:D" + lin.ToString()])
            {
                rng.Style.Font.Bold = false;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                rng.Style.Font.Color.SetColor(Color.Black);
            }

            planilha.Cells.AutoFitColumns();

            planilha.Cells[++lin, 1].Value = "Gerado em " + DateTime.Now.ToString();

            arquivoExcel.Save();
            arquivoExcel.Dispose();

            Workbook workbook = new Workbook();
            //Load excel file  
            workbook.LoadFromFile(arquivo);
            //Save excel file to pdf file.  
            Worksheet worksheet = workbook.Worksheets[0];
            PageSetup setup = worksheet.PageSetup;
            setup.FitToPagesWide = 1;
            setup.FitToPagesTall = 1;
            workbook.SaveToFile(arquivoPDF, Spire.Xls.FileFormat.PDF);

            System.Diagnostics.Process.Start(arquivo);
        }

        private void frmRelEmp_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = Convert.ToDateTime("01/01/1900");

        }
    }
}
