using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GoMVC
{
    public partial class Form1 : Form
    {   //Data
        private readonly DataController _DataController;
        //DbCon
        private DbConControler _DbConController;
        private IDbCon _dbCon;
        //Logger
        private LoggerController _LoggerController;
        public Form1()
        {
            InitializeComponent();
            //inicializar Data
            IData dataModel = new Data();
            _DataController = new DataController(dataModel);
            //inicializar label
            lblDato.Text = "Dato : " + _DataController.GetAppName();
            lblAppRoute.Text = "AppRoute : " + _DataController.GetAppRoute();
            lblAppVersion.Text = "AppVersion : " + _DataController.GetAppVersion();
            lblAppYear.Text = "AppYear : " + _DataController.GetAppYear();
            //inicializar DbCon
            _dbCon = new DbCon(_DataController.GetChain1());
            _DbConController = new DbConControler(_dbCon);
            //inicializar logger
            _LoggerController = new LoggerController();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT [Id], [Name], [Mobile] " +
                "FROM [Test].[dbo].[TableTest]";
            dgv.DataSource = _DbConController.SelectDataTable(query);
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            //actualizar dato
            _DataController.SetAppName(txtDatoNow.Text);
            //actualizar label
            lblDato.Text = "Dato : " + _DataController.GetAppName();

            _LoggerController.TrAcE(0, 56, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
            _LoggerController.TrAcE(1, 57, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
            _LoggerController.TrAcE(2, 58, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
            _LoggerController.TrAcE(3, 59, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
            _LoggerController.TrAcE(4, 60, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
            _LoggerController.TrAcE(5, 61, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
            _LoggerController.TrAcE(6, 62, "Hemos grabado en AppName = Dato: " + txtDatoNow.Text);
        }
    }
}