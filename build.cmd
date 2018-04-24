cd ./hello-world-repo
dotnet restore
dotnet build
dotnet test ./aws-csharp-tests/
cd ./aws-csharp
dotnet lambda package --configuration release --framework netcoreapp2.0 --output-package bin/release/netcoreapp2.0/deploy-package.zip
cd ..