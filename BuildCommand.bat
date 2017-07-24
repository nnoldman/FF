cd ../CS
protoc  --cpp_out=../S/include Command.proto
protoc  --csharp_out=../C/Client/Assets/Scripts Command.proto
::flatc -c -o ../S/include Command.fbs OPCode.fbs
::flatc -n -o ../C/Client/Assets/Scripts Command.fbs OPCode.fbs