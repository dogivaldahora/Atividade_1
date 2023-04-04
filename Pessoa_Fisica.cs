namespace Atividade
{  //Pessoa física sendo subclasse de Clientes           
   class Pessoa_Fisica : Clientes
    {
        public string cpf {get; set;}
        public string rg {get; set;}

        internal void Pagar_Imposto(float val_pag)
        {
            throw new NotImplementedException();
        }
    }
}