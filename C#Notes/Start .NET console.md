Here is the instruction to start .NET console application
1. Navigate to the directory where the program folder will be put
2. Run this command on CMD
```
dotnet new console -o ./<NamaProject>/<CsProjName>
```
If you want to specify framework version use `-f` or `--framework`command like in this example
```
dotnet new console -o ./<NamaProject>/<CsProjName> -f net6.0
```
3. navigate to the project folder
```
cd <NamaProject>/<CsProjName>
```
4. Type your code in `Program.cs`
5. Run `dotnet build` after finish the code for the first time
6. Run `dotnet run` to run the program
7. If the code change and we want to run it just type `dotnet run` without `dotnet build first`
8. Give `.gitignore` file so only important things that uploaded
```bash
dotnet new gitignore
```
