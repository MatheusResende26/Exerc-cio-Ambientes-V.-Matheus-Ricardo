using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
   public  class sexo
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }

        public sexo(int id, string descricao, string sigla)
        {
            this.id = id;
            this.descricao = descricao;
            this.sigla = sigla;
        }

        public sexo()
        {
           
        }

        public List<sexo> listar()
        {
            List<sexo> sexos = new List<sexo>();
            sexos.Add(new sexo(1, "Feminino", "F"));
            sexos.Add(new sexo(2, "Masculino", "M"));
            return sexos;
        }
    }
}
