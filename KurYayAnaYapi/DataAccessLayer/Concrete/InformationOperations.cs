using KurYayAnaYapi.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurYayAnaYapi.DataAccessLayer.Concrete
{
    public class InformationOperations : BaseRepository<Information>
    {

        string repoName;

        public InformationOperations(string repoName) : base (repoName)
        {
            this.repoName = repoName;
        }

    }
}
