// C++ code
//

//Prototipos das funções que serão usadas
//Funções principais
void calculadora();                                              //Função principal para calculadora.
void conversao();											                           //Função principal para conversão.
int anyBaseToDecimal(int fromBase, String num);				           //Mete um numero em qualquer base para decimal.
String decimalToAnyBase(int num, int toBase);				             //Mete um decimal para qualquer outra base.
//Funções complementares
bool isValid(String num, int base);                              //Verifica se o numero é valido para a respetiva base
String getString(String question, bool newLine);			           //Input para string.
int getBase(String question, bool newLine);                      //Input para bases da conversão.
String getBinOctDecHex(String question, bool newLine, int base); //Input para o numero usado na conversão de bases.
int getInteiro(String question, bool newLine);							     //Input para numeros inteiros, limitado a 0-4095.
String getOperacao(String question, bool newLine);						   //Input para operação.
int power(int base, int exponent);							                 //Função potencia externa porque pow() estava a dar problemas

void setup()
{
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, HIGH);//Para saber que arduino está ligado.
}

//Variaveis do loop
String opcao;

void loop()
{
  Serial.println("---------------------");
  Serial.println("--- Projeto Final ---");
  Serial.println("---------------------");
  Serial.println("1 - Calculadora Aritmetica");
  Serial.println("2 - Conversao de Bases");
  
  opcao = getString("Escolha uma opcao usando os numeros: ", false);
  
  switch (opcao.toInt()) {
    case 1:
      Serial.println(opcao);
      Serial.println("");
      Serial.println("--- Calculadora ---");
      calculadora();
      break;
    case 2:
      Serial.println(opcao);
      Serial.println("");
      Serial.println("--- Conversao ---");
      Serial.println("Pode converter usando a base binaria(2), octal(8), decimal(10), hexadecimal(16).");
      conversao();
      break;
    default:
      Serial.println("Erro -> Opcao invalida. Digite 1 ou 2.");
      Serial.println("");
      break;
  }
}
void calculadora()
{
  int num1, num2, resultado;
  String operacao;
  bool isZero;
  
  //Pedir variaveis
  num1 = getInteiro     ("Digite o primeiro numero:      ", false);			//Primeiro Número
  Serial.println(num1);												        // Dá print para mostrar no terminal o input do utilizador
  operacao = getOperacao("Digite a operacao(+, -, *, /): ", false);			//Operação
  Serial.println(operacao);											        // Dá print para mostrar no terminal o input do utilizador
  num2 = getInteiro     ("Digite o segundo numero:       ", false);			//Segundo Número
  Serial.println(num2);												 		// Dá print para mostrar no terminal o input do utilizador

  // Calcular o resultado
    if      (operacao == "+")
    {
      resultado = num1 + num2;
    }
  	else if (operacao == "-")
    {
      resultado = num1 - num2;
    }
    else if (operacao == "*")
    {
      resultado = num1 * num2;
    }
    else if (operacao == "/")
    {
      if (num2 == 0) 
      {
        Serial.println("Erro -> Divisao por zero.");
        Serial.println("");
        isZero = true;	// Para saber se o resultado é zero para depois poder dar apenas um dos erros, ou divisão por zero, ou resultado fora do range.
      }
      else 
      {
		    resultado = num1 / num2;
      }
    }

  if((resultado < 0 || resultado > 4095) && isZero == false)
  {
    Serial.println("Erro -> Resultado fora do range de 0 a 4095.");
    Serial.println("");
  }
  else if ((resultado >= 0 && resultado <= 4095) && isZero == false)
  {
    Serial.println("");
   	Serial.print("Conta:       ");
    Serial.println(String(num1) + " " + String(operacao) + " " + String(num2)); 
    Serial.print("Binario:     "); 
    Serial.println(decimalToAnyBase(resultado, 2));
    Serial.print("Octal:       "); 
    Serial.println(decimalToAnyBase(resultado, 8));
    Serial.print("Decimal:     "); 
    Serial.println(resultado);
    Serial.print("Hexadecimal: ");
    Serial.println(decimalToAnyBase(resultado, 16));
    Serial.println("");
  }
  delay(2000);//Espera um bocado antes de continuar
}
void conversao()
{
  int base1 = 0;
  int base2 = 0;
  String num1;
  
  //Pedir variaveis
  //Base Origem
  base1 = getBase       ("Digite a base de origem: ", false);	//getBase já lida com os erros
  Serial.println(base1);

  //Numero para converter
  num1 = getBinOctDecHex("Digite o numero:         ", false, base1);
  Serial.println(num1);		
  
  //Base Final
  base2 = getBase       ("Digite a base final:     ", false);	// getBase já lida com os erros	
  Serial.println(base2);							
  
  //Check para ver se é numero valido para a respetiva base escolhida
  if (isValid(num1, base1))
  {
    Serial.print        ("Conversao:               ");
   	Serial.println(decimalToAnyBase(anyBaseToDecimal(base1, num1), base2));
    Serial.println("");
    delay(2000);//Espera um bocado antes de continuar
  }
}
int anyBaseToDecimal(int fromBase, String num)                   //Pega num num qualquer e mete-lo em decimal
{
  int numDecimal = 0;
  int exp = 0;
  char digito;

  for (int i = num.length() - 1; i >= 0; i--) //Iterar pelo numero a começar pela direita
  {
    
    digito = num.charAt(i); // Pega no ultimo digito
    if (digito == 'A')
    {
      digito = 10;
    }
    else if (digito == 'B')
    {
      digito = 11;
    }
    else if (digito == 'C')
    {
      digito = 12;
    }
    else if (digito == 'D')
    {
      digito = 13;
    }
    else if (digito == 'E')
    {
      digito = 14;
    }
    else if (digito == 'F')
    {
      digito = 15;
    }
    else
    {
      digito = digito - '0';
    }
  
    numDecimal = numDecimal + (digito * power(fromBase, exp)); // Faz a conta Ex.: 0 + (2 * 8^0)
    num.remove(i);											   // Tira o ultimo digito
    exp++;													   // Soma 1 ao expoente
  } 
  return numDecimal;
}
String decimalToAnyBase(int num, int toBase)                     //Converte decimal para qualquer base
{
  int remainder = 0;
  char tempL;
  String tempF = "";
  
  if (num == 0) //Para dar print a '0' quando o resultado da conta é 0.
  {				// Sem isto apenas dava print a vazio.
  	Serial.print("0"); 
  }
  
  while (num > 0) //'If' de 'letras' só serão usados pelo hexadecimal, ultimo 'else' será a função mais generalizada.
  {
    remainder = num % toBase;
    if (remainder == 10)
    {
      tempL = 'A';
      tempF = String(tempL) + tempF;
    }
    else if (remainder == 11)
    {
      tempL = 'B';
      tempF = String(tempL) + tempF;
    }
    else if (remainder == 12)
    {
      tempL = 'C';
      tempF = String(tempL) + tempF;
    }
    else if (remainder == 13)
    {
      tempL = 'D';
      tempF = String(tempL) + tempF;
    }
    else if (remainder == 14)
    {
      tempL = 'E';
      tempF = String(tempL) + tempF;
    }
    else if (remainder == 15)
    {
      tempL = 'F';
      tempF = String(tempL) + tempF;
    }
    else
    {
      tempF= String(remainder) + tempF;
    }
    num = num / toBase; // Para encurtar o num, e repetir o mesmo com o ultimo digito até que num < 0.
  }
  return tempF;
}
bool isValid(String num, int base)                               //Verifica se o numero é valido para a respetiva base
{
  String numsValidos;
  // Numeros/Valores validos para cada base
  if(base == 2)
  {
    numsValidos = "01";
  }
  else if (base == 8)
  {
    numsValidos = "01234567";
  }
  else if (base == 10)
  {
    numsValidos = "0123456789";
  }
  else if (base == 16)
  {
    numsValidos = "0123456789ABCDEF";
  }
  
  for(int i = 0; i < num.length(); i++)//Itera pelo num para depois pegar um digito de cada vez e verifica se é valido ou não
  {
    char digito;
    
	digito = num.charAt(i);	//Pega no digito daquele index
    if(numsValidos.indexOf(digito) == -1) //'indexOf' retorna -1 quando o digito não encontra o digito na lista
    {
      Serial.print("Erro -> Numeros invalidos para a base ");
      Serial.println(base);
      return false;
    }
  }
  return true;
}
String getString(String question, bool newLine = true)           // Para pedir input ao utilizador e só avança quando tiver o input.
{													   // Por default usa println, mas se meter false na função, não usa ln.
  String temp;
  
  if (newLine)
  {
	Serial.println(question);
  }
  else
  {
    Serial.print(question);
  }
  
  do
  {
   	temp = Serial.readString();
  }while(temp == "");

  return temp;
}
int getBase(String question, bool newLine)                       //Para pedir uma base - 2, 8, 10 ou 16
{
  String base;
  
  do
  {
    base = getString(question, newLine);
    
    if (base == "binaria" || base == "octal" || base == "decimal" || base == "hexadecimal")
    {
      Serial.println("Erro -> Digite o numero respetivo da base.");
    }
    else if (base != "2" && base != "8" && base != "10" && base != "16")
    {
      Serial.println("Erro -> So da para converter de base binaria(2), octal(8), decimal(10) ou hexadecimal(16).");
    }

  }while(base != "2" && base != "8" && base != "10" && base != "16");
  
  return base.toInt();
}
String getBinOctDecHex(String question, bool newLine, int base)  //Para pedir um numero em qualquer base.
{
  int maxDigitos;
  
  //Definir qual será os digitos maximos por cada base.
  if (base == 2)
  {
  	maxDigitos = 12;
  }
  else if (base == 8)
  {
    maxDigitos = 4;
  }
  else if (base == 10)
  {
    maxDigitos = 4;
  }
  else if (base == 16)
  {
    maxDigitos = 3;
  }
  
  String input;
  int inputInt = -1; //-1 para causa do .toInt e assim pode lidar normalmente com o numero '0'.
  					 // .toInt quando falha retorna 0, se input for 0, sabemos que conversão foi sucedida, se continuar -1 não.
  do
  {	
    //É preciso separar em duas variaveis para conseguir lidar com .toInt('string') que vai dar valor 0.
    input = getString(question, newLine);
    inputInt = input.toInt();
    /*
    Serial.print("Debug - input: ");
	Serial.println(input);
	Serial.print("Debug - inputInt: ");
	Serial.println(inputInt);
    */
    if(base == 2 && input.length() > maxDigitos) 	 										//Binario
    {
      Serial.println("Erro -> Digite um numero com no maximo de 12 digitos.");
    }
    else if(base == 8 && input.length() > maxDigitos)  										//Octal
    {
      Serial.println("Erro -> Digite um numero com no maximo de 4 digitos.");
    }
    else if(base == 10 && input.length() > maxDigitos)										//Decimal - Menos de 4 digitos.
    {
      Serial.println("Erro -> Digite um numero com no maximo de 4 digitos.");
    } //                            INTERVALO			          VERIFICAR SE É ZERO DO .toInt  - Ex. input = "ASDASDAD" retorna temp = 0
    else if(base == 10 && (inputInt < 0 || inputInt > 4095 || (inputInt == 0 && input != "0"))) //Decimal - Maior que zero e menor que 4095.
    {
      Serial.println("Erro -> Precisa de digitar um numero entre 0 e 4095.");
    }
    else if(base == 16 && input.length() > maxDigitos) 										//Hexdecimal
    {
      Serial.println("Erro -> Digite um numero com no maximo de 3 digitos.");
    }
   

  }while(!isValid(input, base) || input.length() > maxDigitos || (base == 10 && (inputInt < 0 || inputInt > 4095)));
	
  return input;
}
int getInteiro(String question, bool newLine)                    //Para pedir um numero inteiro dentro do intervalo definino - 12bits
{
  int temp;
  String input;
  
  do
  {
    //É preciso separar em duas variaveis para conseguir lidar com .toInt('string') que vai dar valor 0.
    input = getString(question, newLine);
    temp = input.toInt();
    
    //       INTERVALO				VERIFICAR SE É ZERO DO .toInt  - Ex. input = "ASDASDAD" retorna temp = 0
    if(temp < 0 || temp > 4095 || (temp == 0 && input != "0"))
    {
      Serial.println("Erro -> Precisa de digitar um numero entre 0 e 4095.");
    }
    
    
  }while(temp < 0 || temp > 4095 || (temp == 0 && input != "0"));
  
  return temp;
}
String getOperacao(String question, bool newLine)                //Para pedir operacao ao utilizador e só avança quando tiver a operacao correta.
{
  String temp;
  
  do
  {
   	temp = getString(question, newLine);
    
    if(temp != "+" && temp != "-" && temp != "*" && temp != "/")
    {
      Serial.println("Erro -> Precisa de digitar uma operacao existente.");
    }
  }while(temp != "+" && temp != "-" && temp != "*" && temp != "/");

  return temp;
}
int power(int base, int exponent)                                //Função pow() do arduino não estava a funcionar em condições por isso optou-se por usar uma função externa.
{								  //Se usar pow() -> 8^1=7.99999 e depois como é inteiro, arrendonda para 7, o que acabava por dar valores errados.
    int result = 1;
  
    for (int i = 0; i < exponent; i++) {
        result = result * base;
    }
    return result;
}
