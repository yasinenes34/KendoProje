using Kendo.DAL.Abstract;
using Kendo.DAL.Model;
using Kendo.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendo.DAL.EntityFramework
{
    public class EfStudent:GenericRepository<Student>,IStudnet
    {
    }
}
