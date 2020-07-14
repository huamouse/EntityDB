using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Way.EntityDB.Design;
using Way.EntityDB.Design.Actions;
using System;
using Way.EntityDB.Design.Services;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using Natasha.CSharp;
using System.Xml;

namespace Way.EntityDB.Test
{ 
    [TestClass]
    public class Test
    {
        /// <summary>
        /// ss&amp;&gt;dd
        /// </summary>
        [TestMethod]
        public void test()
        {

            

            AssemblyDomain.Init();

            for (int i = 0; i < 100; i++)
            {
                //使用 Natasha 的 CSharp 编译器直接编译字符串
                AssemblyCSharpBuilder sharpBuilder = new AssemblyCSharpBuilder();

                //给编译器指定一个随机域
                sharpBuilder.Compiler.Domain = DomainManagement.Random;

                //使用文件编译模式，动态的程序集将编译进入DLL文件中，当然了你也可以使用内存流模式。
                sharpBuilder.UseFileCompile();

                //如果代码编译错误，那么抛出并且记录日志。
                sharpBuilder.ThrowAndLogCompilerError();
                //如果语法检测时出错，那么抛出并记录日志，该步骤在编译之前。
                sharpBuilder.ThrowAndLogSyntaxError();

                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                //添加你的字符串
                sharpBuilder.Add(@"using System; 
public enum Log_TypeEnum:int
{
    

/// <summary>
/// </summary>
SysLog = 1,

/// <summary>
/// </summary>
UserLog = 1<<1,

/// <summary>
/// </summary>
AdminLog = 1 << 2
}
");

                //编译出一个程序集
                var assembly = sharpBuilder.GetAssembly();

                 
                sw.Stop();

            }
        }
    }

   class TestItem:DataItem
    {

        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                }
            }
        }
    }

}
