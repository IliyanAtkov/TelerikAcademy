// Write a program that parses an URL address given in the format:
// [protocol]://[server]/[resource]
// 		and extracts from it the [protocol], [server] and [resource] elements.
// For example from the URL http://www.devbg.org/forum/index.php
// the following information should be extracted:
// 		[protocol] = "http"
// 		[server] = "www.devbg.org"
// 		[resource] = "/forum/index.php"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class UrlAdress
{

    static void ExtractUrl()
    {
        string url = "textt some http://www.devbg.org/forum/index.php and here another";
        string pattern = @"(?<protocol>\w+)://(?<server>www\.\w+\.\w+[^/])(?<resource>/\w+\S+)";
        Match match = Regex.Match(url, pattern);
        while (match.Success)
        {
            Console.WriteLine("protocol = {0}",match.Groups[1]);
            Console.WriteLine("server = {0}", match.Groups[2]);
            Console.WriteLine("resource = {0}", match.Groups[3]);
            match = match.NextMatch();
        }
    }
    static void Main()
    {
        ExtractUrl();
    }
}

