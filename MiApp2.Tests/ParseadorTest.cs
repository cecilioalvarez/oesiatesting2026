namespace MiApp2.Tests;

using MiApp2;
using Moq;

public class ParseadorTest{

  

    
    [Fact]
    public void Instanciar_Parseador_Documento_A()
    {       
            Documento documento= new Documento(ObtenerLineasAlumnosClase());
            ParseadorDocumento parseador= ParseadorDocumento.ObtenerParser(documento);
            Assert.IsType<ParseadorDocumentoA>(parseador);

    }

        private List<string> ObtenerLineasAlumnosClase()
    {
        return new List<string>
    {
        "*****************",
        "antonio,matematicas,7.5",
        "antonio,lengua,8",
        "-----------------",
        "gema,matematicas,5",
        "gema,lengua,9",
        "*****************"
    };
    }
}
