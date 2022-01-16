using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
    public class PessoaTelefoneModel
    {
        public int Id { get; set; }
        public int TelefonePessoal { get; set; }
        public int TelefoneResidencial { get; set; }
        public int TelefoneRecado { get; set; }

        public PessoaTelefoneModel(int telefonePessoal = 0, int telefoneResidencial = 0, int telefoneRecado = 0, int id = 0)
        {
            this.Id = id;
            this.TelefonePessoal = telefonePessoal;
            this.TelefoneResidencial = telefoneResidencial;
            this.TelefoneRecado = telefoneRecado;
        }
    }
}