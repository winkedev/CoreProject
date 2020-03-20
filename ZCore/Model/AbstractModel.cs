using ZCore.Util;

namespace ZCore.Model
{
    public abstract class AbstractModel
    {

        protected T Clone<T>() where T: AbstractModel
        {
            return ((T)this).CloneObject();
        }

        public abstract object Clone();

    }
}
