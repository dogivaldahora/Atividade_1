namespace Atividade
{  //Pessoa Jurídica sendo subclasse de Clientes
   class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}
        public override void pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto; 
        }

        internal void Pagar_Imposto(float val_pag)
        {
            throw new NotImplementedException();
        }
    }
}