using System.CodeDom;

namespace Common
{
    public class CtorAndMethodComponent : IDomComponent
    {
        private string _name;
        public CtorAndMethodComponent()
        {
            return;
        }

        public CtorAndMethodComponent(string name)
        {
            _name = name;
        }

        public string Execute()
        {
            return "blah";
        }
    }
}