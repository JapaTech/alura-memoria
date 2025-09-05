# Estudos sobre Imutabilidade e Performance
Este repositório documenta meu estudo sobre as diferentes estruturas: classe, struct, record e record struct, no C#. É um estudo de como cada qual funciona, como elas performam, onde acontece a alocação e quando usar cada.

## Linguagens, Ferramentas e Tecnologias
> C#,
> Visual Studio 2022,
> .Net 8

## O que aprendi
### Classe

    public class Animal
        {
          public string Nome { get; set; }
          public int Idade { get; set; }

          public void Adotar()
          {
            //... Processo de adoção
            Console.WriteLine($"{Nome} foi adotado");
          }
        }

Caracterísicas
- Tipo de referência (alocado no Heap)
- Suporta herança, polimorfismo e interfaces
- Mutável por padrão
- Igualdade por referência.

Quando Usar
- Necessidade de comportamentos complexos
- Quando a identidade do objeto é importante
- Precisa de herança
- O objeto precisa ser alterado

### Struct
    public struct PontoCartesiado
    {
      public double x;
      public double y;
    }

Características
- Tipo de valor (alocado na stack/inline)
- Não suporta herança (só interfaces)
- Mutável por padrão (mas recomendado imutável)
- Igualdade por valor.

Quando usar:
- Pequenos objetos
- Dados simples sem comportamento complexo
- Quando cópias precisam preservar a integridade dos objetos
- Não precisa de identidade

### Record
    public record PessoaDTO
      {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
      }

Características
- Tipo de referência (semelhante a class)
- Imutável por padrão (propriedades init-only)
- Igualdade por valor automática
- Cópias imutáveis usando a palavra with

Quando Usar
- Dados imutáveis (DTOs, entidades de domínio)
- Quando igualdade por valor é essencial
- Código conciso para modelos de dados
- Copiar e guardar dados de classes

### Record Struct
    public readonly record struct DadosTecnicosProduto
      {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string CodigoDeBarras { get; set; }
      }

Características
- Tipo de valor (como struct normal)
- Pode ser mutável ou imutável se usar "readonly" na delaração
- Igualdade por valor automática

Quando Usar
- Pequenos objetos imutáveis com igualdade por valor0
- Quando precisar evitar alocação no heap
- Substituição para structs tradicionais que precisam de igualdade

Ex: Coordenadas, Chaves compostas, Valores simples

