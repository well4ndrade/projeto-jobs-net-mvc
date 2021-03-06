# Comandos iniciais:
``` bash
  mkdir entity-framework
  cd entity-framework
  dotnet new mvc
```

# Comandos git:
``` bash
  git init
  git add .
  git commit -m "Iniciando projeto"
  code .gitignore # gerei o conteúdo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore
  Criei o repositório e rodei os comandos
  git remote add origin git@github.com:torneseumprogramador/entity-framework.git
  git branch -M main
  git push -u origin main
```

# Componentes instalados:
``` bash
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
```

# Comandos para migração:
``` bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add UsuarioAdd
dotnet ef database update
```

# Instalação do code generator
``` bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de usuarios
``` bash
dotnet aspnet-codegenerator controller -name UsuariosController -m Usuario -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

dotnet aspnet-codegenerator controller -name EnderecosController -m Endereco -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

dotnet aspnet-codegenerator controller -name VagasController -m Vaga -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
```
# Erro de certificados que ocorreu foi resolvido: (Executar na API e no MVC)
``` bash
dotnet dev-certs https --clean
dotnet dev-certs https --trust

```

