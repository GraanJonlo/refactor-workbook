namespace Chapter06.Ex15
{
    using System;
    using System.IO;

    public class Template
    {
        public void ApplyTemplate(string template, string code, StringWriter sw)
        {
            string altcode;

            try
            {
                // Substitute for %CODE%
                int templateSplitBegin = template.IndexOf("%CODE%", StringComparison.Ordinal);
                int templateSplitEnd = templateSplitBegin + 6;
                string templatePartOne = template.Substring(0, templateSplitBegin);
                string templatePartTwo = template.Substring(templateSplitEnd, template.Length);
                template = templatePartOne + code + templatePartTwo;

                // Substitute for %ALTCODE%
                templateSplitBegin = template.IndexOf("%ALTCODE%", StringComparison.Ordinal);
                templateSplitEnd = templateSplitBegin + 9;
                templatePartOne = template.Substring(0, templateSplitBegin);
                templatePartTwo = template.Substring(templateSplitEnd, template.Length);
                altcode = code.Substring(0, 5) + "-" + code.Substring(5, 8);
                sw.Write(templatePartOne + altcode + templatePartTwo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in substitute()");
            }
        }
    }
}
