using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            Element el = new Element();
            el.Name = name;
            return el;
        }

        public IElement CreateElement(string name, string content)
        {
            Element el = new Element();
            el.Name = name;
            el.TextContent = content;
            return el;
        }

        public ITable CreateTable(int rows, int cols)
        {
            Table currentTable = new Table(rows, cols);
            return currentTable;
        }
    }

    public class HTMLRendererCommandExecutor
    {
        private static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        private static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }

    public class Table : Element, ITable
    {
        private IElement[,] table;
        private int rows;
        private int cols;

        public Table(int inputRows, int inputCols)
        {
            this.table = new IElement[inputRows, inputCols];
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Cols
        {
            get { return this.cols; }
        }

        public IElement this[int row, int col]
        {
            get { return this.table[row, col]; }
            set { this.table[row, col] = value; }
        }

        public override string ToString()
        {
            return
                string.Format(
                    "<table>" + PrintTable() + "</table>");
        }


        private string PrintTable()
        {
            string str = string.Empty;
            for (int row = 0; row < table.GetLength(0); row++)
            {
                str += "<tr>";
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    str += "<td>";
                    str += table[row, col]; //FormatTextContent(table[row, col]);
                    str += "</td>";
                }
                str += "</tr>";
            }
            return str;
        }
    }

    public class Element : IElement
    {
        private string name;
        private string textContent;
        private List<IElement> childElements;

        public Element()
        {
            childElements = new List<IElement>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string TextContent
        {
            get { return this.textContent; }
            set { this.textContent = value; }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return new List<IElement>(this.childElements); }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", this.Name == null ? "" : "<" + this.Name.ToString() + ">",
                this.textContent, this.childElements.Count > 0 ? PrintChilds() : "",
                this.Name == null ? "" : "</" + this.Name.ToString() + ">");
        }

        private string PrintChilds()
        {
            string st = String.Empty;
            foreach (var childElement in childElements)
            {
                st += childElement.ToString();
            }
            return st;
        }

        private string FormatTextContent(string text)
        {
            string formatted = string.Empty;
            if (text == null)
                text = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    formatted += "&lt;";
                }
                else if (text[i] == '>')
                {
                    formatted += "&gt;";
                }
                else if (text[i] == '&')
                {
                    formatted += "&amp;";
                }
                else
                {
                    formatted += text[i];
                }
            }
            return formatted;
        }

        public void Render(StringBuilder output)
        {
            Console.WriteLine(output);
        }
    }
}