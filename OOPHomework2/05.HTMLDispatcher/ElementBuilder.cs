using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _05.HTMLDispatcher
{
    public class ElementBuilder
    {
        private static readonly string[] ValidHtmlTags = 
        { 
            "!DOCTYPE", "a", "abbr", "acronym", "address", "applet", "area", "article", "aside","audio","b","base", "basefont","bdi","bdo","big",
            "blockquote","body", "br","button", "canvas","caption","center","cite","code","col","colgroup","datalist","dd","del","details","dfn",
            "dialog","dir","div","dl","dt","em","embed","fieldset","figcaption","figure","font","footer","form","frame","frameset","h1","h2","h3",
            "h4","h5","h6","head","header","hgroup","hr","html","i","iframe","img","input","ins","kbd","keygen","label","legend","li","link",
            "main","map","mark","menu","menuitem","meta","meter","nav","noframes","noscript","object","ol","optgroup","option","output","p","param",
            "pre","progress","q","rp","rt","ruby","s","samp","script","section","select","small","source","span","strike","strong","style","sub",
            "summary","sup","table","tbody","td","textarea","tfoot","th","thead","time","title","tr","track","tt","u","ul","var","video","wbr"
        };
        private static readonly string[] SelfClosingTags =
        {
            "area", "base", "br", "col", "command", "embed", "hr", "img", "input", "keygen", "link", "meta", "param", "source", "track", "wbr"
        };
        private string element;

        public ElementBuilder(string element)
        {
            this.Element = element;
            this.Content = "";
            this.Attributes = new Dictionary<string, string>();
            this.Repetitions = 1;
            this.IsSelfClosing = Array.IndexOf(SelfClosingTags, element) != -1;
        }

        public string Element
        {
            get { return this.element; }
            private set
            {
                if (Array.IndexOf(ValidHtmlTags, value) == -1)
                {
                    throw new ArgumentException("The value entered isn't a valid HTML5 element.", "element");
                }
                this.element = value;
            }
        }

        public string Content { get; private set; }
        private Dictionary<string, string> Attributes { get; set; }
        public int Repetitions { get; private set; }
        public bool IsSelfClosing { get; private set; }

        public void AddAttribute(string attribute, string value)
        {
            if (string.IsNullOrWhiteSpace(attribute))
            {
                throw new ArgumentNullException("attribute", "Attribute cannot be empty.");
            }
            this.Attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            if (this.IsSelfClosing)
            {
                throw new ArgumentException("Self-closing HTML element cannot have inner content.", "content");
            }
            this.Content = this.Content + content;
        }

        public static ElementBuilder operator *(ElementBuilder currentElement, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count should be greater than zero.");
            }
            var newElement = new ElementBuilder(currentElement.Element)
            {
                Attributes = currentElement.Attributes,
                Content = currentElement.Content,
            };
            newElement.Repetitions *= count;
            newElement.IsSelfClosing = currentElement.IsSelfClosing;

            return newElement;
        }
        public static string[] GetValidHtmlTags()
        {
            var tags = new string[ValidHtmlTags.Length];
            Array.Copy(ValidHtmlTags, tags, ValidHtmlTags.Length);
            return tags;
        }
        public static string[] GetSelfClosingTags()
        {
            var tags = new string[SelfClosingTags.Length];
            Array.Copy(SelfClosingTags, tags, SelfClosingTags.Length);
            return tags;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var initial = new StringBuilder();

            initial.Append(string.Format("<{0}", this.Element));
            foreach (var attribute in this.Attributes)
            {
                initial.Append(string.Format(" {0}=\"{1}\"", attribute.Key, attribute.Value));
            }
            initial.Append(this.IsSelfClosing ? " />" : string.Format(">{0}</{1}>", this.Content, this.Element));
            for (var i = 0; i < this.Repetitions; i++)
            {
                result.Append(initial);
            }
            return result.ToString();
        }
    }
}
