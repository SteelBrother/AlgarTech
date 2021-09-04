using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeveloperWEBAPI.Abstracciones;

namespace TestDeveloperWEBAPI.Entidades
{
    public abstract class Entity : IEntity
    {
        public int Id { set; get; }
    }
}
