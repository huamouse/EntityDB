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
using System.Xml;
using FllowOrderSystem.DBModels;

namespace Way.EntityDB.Test
{ 
    [TestClass]
    public class Test
    {
        protected  string GetDesignString()
        {
            var result = new StringBuilder();
            result.Append("\r\n");
            result.Append("H4sIAAAAAAAAE81da1Pbxhr+Kxk+J41lbGN3mg8pJFPmkMtA2p6ZQ6cj7AU0MRKV5KRMJjPmpDlAEkLI5UACLSQlDc0J0DaEgA3hz1iy+dS/cPYiG2lXWOuLZH/C9uqyz+677/u8l11udVwTh9JA6/j8X7fIx8viGOj4vGPgh/QAUG8AteN0R79yk1zQq4Mx8sm6SkrB");
            result.Append("5m/EdAZ+icdun6406BPj4Lipo1sFog7w888ndUmRO2zXJhVZB7Juu/zWIOnLYMfn8KOUgn+F04P4evgRNqpiCnytAXWwA/7cI+rikKiB3h7rOqlPSV6Hn0O34ZduJZ0Zk7VB1O2qz+pN4af1auczutIrJ1UwBnsFrxkW0xpATxLly5l02vZLaugaxIkfMySNSOhq+Gsa");
            result.Append("yCP6KP4Vf8dQKp3r1a7+A3/R1Qx6hqKmgIq7FcKtPZKWVKUxSRZ1RS2/C46W1fcovCgpjqMxxG84+vWhubqP31OBNKBPoLHjBGP1w4alDOSCnBnrAcOSTH4+e7a4slHMHQ4OygOjiqqfOndK+OIL2OtB+ezZo2eHpKlPkUdIi2C1TM0W8k/gx6+kkVHSErZa/rd49Gre");
            result.Append("armogh8yQE5OkEs6ySWF3bz5YRJ+vCRK8oAOxWiMtEdIu3mYLR0uwY/9YkpKimnSGC3fbHW3G2IHah8EQtpjVvvBQ/L+PuVm5fXnYHsXaS8d5EnP+2D/9G9FFYwqGQ2gK+LW6zdembMraEB0ZbxP0TTy/MQxvl8fHj3/3YLYL2nXraGxRq24/t6YfI3vB2LKgi4ItYhR");
            result.Append("eUKP5aiTR45ilBwVN7OF/H2nHPUA9Ajrmrql6YaoJkdFlcYUDoVqgxXhgdVFwTL2s8ajrdLmq6PFu05wF2T04oHMEHreUCPLZUhyX/cpMCxm0jpWavjXGgFHeQDHXQEbfz4rruWcgHu1byRNGmpIM/gFNcYDNUFBJbNayH9kFWB5Vq+qUrIRvCklUx6wupdjFw82pBAc");
            result.Append("4Ar7i+adVQiOQjYOkpKYbgdccS5cAoXLXM5CU0GmzphaNdZ+P2HqesQJrQk2rG54CR54EdocF+/tmNlJ2hyLeqYZWCh7fFnB9qxsSjZmjE93jc2X5uousofghgRuSsQWkytI21H2RelwCv5wfnxcVW6AFLwgzLeohdpGUOAiNBHGEm1Dff3SfLpTXLrnHMhrio5EXxm2");
            result.Append("tFDrZF8QuKDR1oiAKj6ccuIikPohQ241rDAXLNrmlA7nO435dbi0jbU3xtIv5uM1J8B+oKti0kLTWoRcRjVCm5pCbs1cfAKVlfnsD0omkfvQal0lcNnPKG1jzAeTkN8a0/8xdu8UX/wEsRlZypJeVTQJXQ8f3Q7yyWVLo7TNIRrFogu5HDOHFZuj+jGLjXIjgcsSRWlL");
            result.Append("VLqzzCiabyW5HWaRy0GJ0naBrEHosDGw4BqUK/5bq8FxuSlRxk9Z2zbuzGXUtBPZV9Ar7E0q8tdWQ1M9MKFWD4zL6EVp62Aufii+oVbcZSl5nXxpNqhojZi4LF6UtgdEoxCJhHrFmH3mbhi6lUxDJo9bp9QImouZxWh7UVyaNqZ/r4aXMBm/UPPj45LUGG0nCrk5c3al");
            result.Append("Gj4U4mk9Oi6ZjYVd9ac5c/8kaHoj1q8ZujPMF7nqdF2MRDhPlMmWY+OyC7EIrTwXXhs/T5GpK757ykwdZJ7NmL3GZZKLV8dokkJcBrepuyT+2BaeXpiLWsdoskKAEYXCAENapNWwuJh0gtaQxsETY2aW+A1QFo+m5tzdhcDsXq3Wni9oFWeiVjZPyZybKx3+4Y4bPnhA");
            result.Append("V1vPaoRqOL9DbT3/7FbkYWkEJ8bIL4MoY2ZPzKWsxJo9yyfA21FCEAW1AE6xeaUFu/xMC9JGrvRxBRrv0uan4sGmc4ouptPKzStohAaArkvySH25w7D9mdJJKUNrYqtmDMsyfjypYfuk1pce7LR3L6CsZthDFnn6HWHMdnt0notqCbQUmotbxqPfzOUZ89k0nYQheacg");
            result.Append("cjB0uNYDKhf5EhwCBpWAql+TGvLjoJIBevkRdc8TF7sSHFJ2QU61Rde5mJNAMydjKWdsvkDqbmoVcvrBQfmUDPtZerleXMsVdmdJ+9/7DxAzNB4/uARFQxpPA2PubenOARTNwm62sPsWfmBifr5zSY8B4WJcAs24yFAY2dlmDkX50lYOB1/+kA4oEUNo/nfPeDRPuQyS");
            result.Append("CpIN5vRPrBAxN35FLxyULyrqTVFN2bJPc7OkZUhMXrea6sw7eQwYJ8ejFxQcrYXX1rBl80evfmY9LZR/Oj/WILflou8eELlCwgKTMK+Am5pn8LUPOL68YZjJZmCXy/JNtp4WPmGlaMy+L+TvHc8sbib4jdlV8iP5ijIg5DZXah9E4NxrYLioVJhxsjEbgVCPXsyZM1mk");
            result.Append("8HJvjCdUlrpXwwz5POp/23ETvsQk67ZNPyrk1kiFSOHwZ/PemtsMY6cAV1T4N8es4/pZKBSucRCqkBzUs7SoaQ7ujye04u3Y3Ho2RI8kBNpD9GFu/ig7ae5Mm5NbtIRckdMTl4CmiSMtKSLyGp8qTKqm8RHiMYdmxB1vvq0svs8X8ytEBaESwAkN+tH2Ph0bz+LTdXP6");
            result.Append("Y+VSuvMnmlL+sXNn/wiNfVyYtFV+p3SIeFfxzWPKXIK02EgurnG3swqNZKSBHXunPDAVDziXbC7sQKNR2toorWcpCi3KI5nGVglvJMhrGKrQR55FwQaLbqHnfS1LP+BVanW8V+tOZ+AYqiBlfzqOn6DH4zsdEQmHk//d6WqRmu/JZd87brnta9Aq7mfQik5gkHAVMdCF");
            result.Append("fLawN+1moPGwXFWVVCap1xm7chS+Nzl41WmXw/qCV+Ewg9eSgMYCQd66pNNjEXH1np5W5/QNTIwNKY1wK16F4IGFi0mFHZGSPnADqI1ps4anoFp0yktHlZ/GqaRowWOVk7UKv6ev9FcnJfzUSXTisRxI/8M4eOaih76SNDgDE3XqIQe9arIeijRBD9E0xyr/m190SS8H");
            result.Append("FKeOVF8efBqKoTF4kgu5nBNXe0DiikeHT6jUnF9EzAxXchhzVA39FRX1TkxjilEDTjdPpnGYXJHrTjrYQWauGsZ2wFYlEsdS8EwyCV1L3HE7+e5kqjmXID2i886BlAp4oK0SlONHS6eSjL33hfyT4p954xcqbNGdVjTgl29K5Iu8HEVzkc6vqDubX4pdWGM/B6+suLC4");
            result.Append("Y8gltfbIzdw37q1XHnVJlDN4n15ngxqvisrjH27a7Bn7WZToX/uztP3aeLhiLK1S62ocyBdFKd0PRM2fCHpp+zfk6n/46WhqvrA7W9pBA3tZ0S/ISmZk9JIig4nj8beCmsvvUAjz+SNjegf+bIvk9sGR0Y+nwhHjdt7UI044b7E2YLJR1cot9sho+a7ytkwm8EbuOoVu");
            result.Append("Q5E2uGB1kER3RO1I0G7Wh28qb0AbJiGr01UFCYy1a7N4MF/MLxv7/zZ20UaXy0C/qajXL6iqAgWzvHOT1PA93jQeTUMv/Whhu7SD3HU0OtIYUDLozfHGBLAWxxqJDCt8DM3YvV+JRruo82CC817Lror/wL3s4g5Hzx8dVhny8mqxd4YjYOYxDu7RJWe8LE57hC3f/+M1");
            result.Append("uVXoMf/k0jq1uH7fyM2Vpt4Wn66fQKD9qQWnkwwe6PlyDFEHgEAKCDz6zVVAkKBlkVg6ZoMpMnCB7C71EsUq9J9bFBOMeccshAGNGUtboK4lxXMSaiHOpEZJfufjX8X8nDG5bG68gqsRkjIroeCWB4RdCKpOiQ5geY1RLWkeaoyaHCnyiGFbQRIqbn26oVd6vy2QAHki");
            result.Append("5Gcwiqmm3pkube+5BaPgTGqZMdAPklBA6otGdcZP+xeNitlluc6STjrEAVmE+e4TE7UJMhrlgFVvySdz5EF+0Q1Xe0Di2xnNFCBg34Nie+JEMLTBAxFXfC3CFFhjx9RuUMyZJ8X88xNCpFCrIV2rjrXCkHgMAFfkLULzJjf3LBjPzAMOV51ghInzH7wz7r4uHDyHoCxp");
            result.Append("HZRPHb36Ce2YtrWh6ijc/Pf+A/OvctPefWNmFv5SOnxe2H1rbCyYmx8KeytQPEg1JbyLUlLKl2JalJOgLZYAH3NmlsDBu9L2b8bURmlrklHBsjYM1G+UTHIUBLEPxANgtVLawLiQw0b7T4acrwuGDQl+siGm6Obue/P9ujG9UHpJ+dMQehKocn08KOrn1pauxnlQlNbE");
            result.Append("bZCVc8CqkwdFmXgJLvZqCQnywFONBDW3UIiexJNWOhJ3u0oJaL2H/VzvdJaWyAM0pZbAb+25ne1B6kvsJ3zUrAFifnpC8cY1QIw5hgGPjNXRliiAePUFw6UAuhhHqDzPLaog8gDF5Qp10a5QC8+j8cDD5Qh10SzQfkxZCyP6Htiq+TiBEUCHagqwijPR6aeadldGRCAY");
            result.Append("Zobw2ooUalbNXY59l01WzYnGVXOXO4lppWpOVF8ZfKqZ2Uuz8Npcpk506GlwmfO5sh5w+JQyE1jFcNyqS/wqLIFvJNUGtp2B8+vw77cAXD9XLhlZnkaVInAVjp7zKhPxGBc+5c4W/LEHdwRxaocHGL4jkJndPS5HaQZTMOUBp1r4JTDjdKyZg7RMEV/PymdK5rAyLhy+");
            result.Append("ZPZ0YbTysFKfVUpEmWf5r9eFJpyin2AUYYsPqWvGyXsJ90MFnaCCPlGwgeP3gj2nJhH1dUky+/NxMhOdPJBbYmuWXViTauWw61mnQsJRcR+YIyl4xJP4Tu3Acu2yW9dv6+XVe76DOxKOoEogW2m8Os53okQiYe/4l5reHEZYf7e5znUIh0JO0ub3uXgeneY6qSEcavhf");
            result.Append("0tRZwO/Vfb5NGCGHd1rr3oO6iUATkgrhkGOnW0BHDnqlDTi7HmW7Hsjxzl7d59uMFHLYpOBK8Ly6z3X8UDjk8p9mUIm8S8EHKqkMJt3tOTN80JijcXDVpBs0sgelLbAFxyThV4tjYS557GuWGSXiZwge+jdqeEfMZ72yHovgFzmutmgme/2ArkryCHvDMdfkv8eB6cSu");
            result.Append("fYdgodYBoFs3RoShMEhFQmdSYChyJhKLJs/EY6nhM6FIIhQdCsWiw2Ko4/b/AUEaK61CbgAA");
            return result.ToString();
        }
        [TestMethod]
        public void test()
        {
            var actions = DBUpgrade.GetDatabaseActions(GetDesignString());
            using ( var db = new FllowOrderSystem.DBModels.DB.FllowOrders("Server=192.168.40.133;Port=5432;UserId=postgres;Password=123456;Database=fllowsystem;", DatabaseType.PostgreSql) )
            {

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
