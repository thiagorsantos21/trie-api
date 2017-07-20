using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Trie.Util
{
    public class Config
    {
        public static string FileWordsConfig => ConfigurationManager.AppSettings["FileWords"];
    }
}