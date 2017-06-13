using System;
using System.Collections.Generic;
using Ops.Template.Compiler.Text;

namespace Ops.Template.Compiler
{
    public class DotNetReferences
    {
        #region Private fields

        private List<String> _References = new List<string>();

        #endregion

        #region Private methods

        #endregion

        #region Public methods

        public void Add(string reference)
        {
            _References.Add(reference);
        }

        public void Remove(string reference)
        {
            _References.Remove(reference);
        }

        public IEnumerable<string> GetReferences()
        {
            foreach (string reference in _References)
            {
                yield return reference;
            }
        }

        public string this[string nameSpace]
        {
            get { return ReferenceInCode.GetDefaultReferenceDllName(nameSpace); }
        }

        #endregion
    }
}