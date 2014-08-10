using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remind.Model;

namespace Remind
{
    public interface ILogin
    {
        void Show (SocialInfo socialInfo);
    }
}
