
namespace ThreeTuple
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ThreeTuple<TfirstElement, TsecondElement, TthirdElement>
    {
        private TfirstElement firstElement;

        private TsecondElement secondElement;

        private TthirdElement thirdElement;
        public ThreeTuple(TfirstElement firstElement, TsecondElement secondElement, TthirdElement thirdElement)
        {
            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
            this.ThirdElement = thirdElement;
        }

        public TfirstElement FirstElement
        {
            get { return this.firstElement; }

            set { this.firstElement = value; }
        }

        public TsecondElement SecondElement
        {
            get { return this.secondElement; }

            set { this.secondElement = value; }
        }

        public TthirdElement ThirdElement
        {
            get { return this.thirdElement; }

            set { this.thirdElement = value; }
        }

        public string PrintItems(TfirstElement firstElement, TsecondElement secondElement, TthirdElement thirdElement)
        {
            return $"{firstElement} -> {secondElement} -> {thirdElement}";
        }
    }
}
