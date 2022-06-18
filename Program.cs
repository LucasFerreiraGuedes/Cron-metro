
class Progam
{


static void Main (string [] args){
    menuPrincipal();
}
static void menuPrincipal(){
    Console.WriteLine("Seja bem vindo(a) ao Menu Principal");
    Console.WriteLine("Você quer que a contagem seja progressiva ou regressiva?");
     string resposta = Console.ReadLine().ToLower();
    if(String.Equals(resposta, "progressiva")){
         cronometroProg();
    }
     else{
        cronometroReg();    
         }   
}
static void cronometroProg(){
    int time = Start();
    Console.Clear();
    for (int i = 0; i <= time;i++){
        Console.WriteLine(i);
    Thread.Sleep(1000);
    }
}
static void cronometroReg(){
    int time = Start();
    Console.Clear();
    for (int i = time; i >= 0;i--){
        Console.WriteLine(i);
    Thread.Sleep(1000);
    }

}
static int Start(){
    Console.Clear();
    Console.WriteLine("Contagem em segundos digite o tempo e sua unidade => 10s => 10 segundos");
    Console.WriteLine("Contagem em minutos digite o tempo e sua unidade => 10m => 10 minutos");
    Console.WriteLine("Digite 0 para voltar ao menu principal");
    string tempo = Console.ReadLine().ToLower();
    char type = char.Parse(tempo.Substring(tempo.Length - 1,1));
    int quantidade = int.Parse(tempo.Substring(0,tempo.Length - 1));
    if (quantidade == 0)
    menuPrincipal();
    if (type == 'm')
    quantidade *= 60;
    return quantidade;
}
}
