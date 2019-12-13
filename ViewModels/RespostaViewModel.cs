using RoleTopMVC.ViewModels;

namespace RoleTopem.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public string Mensagem {get;set;}

        public RespostaViewModel()
        {

        }

        public RespostaViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}