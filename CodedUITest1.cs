using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CalculadoraWindowsCUIT
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class criaArquivoTexto
    {
        public criaArquivoTexto()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"C:\Users\Lucas Ribeiro\Documents\Visual Studio 2013\Projects\CalculadoraWindowsCUIT\teste2.csv",
                    "teste2#csv",
                    DataAccessMethod.Sequential), 
        DeploymentItem("teste2.csv"), 
        TestMethod]

        public void testCriarArquivoTexto()
        {
            this.UIMap.writeInNotepadParams.CampoDeTextoText = TestContext.DataRow["texto"].ToString();
            this.UIMap.saveFileParams.txtNomeDoArquivoEditableItem = TestContext.DataRow["arquivo"].ToString();
            this.UIMap.verificaNomeNaBarraDeTituloExpectedValues.BarraDeTitulosDisplayText = TestContext.DataRow["arquivo"].ToString();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.openNotepad();
            this.UIMap.writeInNotepad();
            this.UIMap.saveFile();
            this.UIMap.verificaNomeNaBarraDeTitulo();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
