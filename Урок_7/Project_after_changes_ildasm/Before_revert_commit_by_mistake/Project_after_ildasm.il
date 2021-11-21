
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Diagnostics.Process
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly Project_before_changes
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 35 2E 30 01 00 54 0E 14   // ersion=v5.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 16 50 72 6F 6A 65 63 74 5F 62 65 66 6F 72   // ...Project_befor
                                                                                                      65 5F 63 68 61 6E 67 65 73 00 00 )                // e_changes..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 16 50 72 6F 6A 65 63 74 5F 62 65 66 6F 72   // ...Project_befor
                                                                                                      65 5F 63 68 61 6E 67 65 73 00 00 )                // e_changes..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 16 50 72 6F 6A 65 63 74 5F 62 65 66 6F 72   // ...Project_befor
                                                                                                    65 5F 63 68 61 6E 67 65 73 00 00 )                // e_changes..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Project_before_changes.dll
// MVID: {9099E558-BEE6-4D75-B7F2-B9D0FEB589F7}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x055D0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Project_before_changes.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       142 (0x8e)
    .maxstack  3
    .locals init (string V_0,
             class [System.Runtime]System.Text.StringBuilder V_1,
             string V_2,
             class [System.Runtime]System.Random V_3,
             int32 V_4,
             string V_5,
             int32 V_6,
             int32 V_7)
    IL_0000:  nop
    IL_0001:  ldstr      "https://www.google.com/search\?q="
    IL_0006:  stloc.0
    IL_0007:  newobj     instance void [System.Runtime]System.Text.StringBuilder::.ctor()
    IL_000c:  stloc.1
    IL_000d:  ldloc.1
    IL_000e:  ldloc.0
    IL_000f:  callvirt   instance class [System.Runtime]System.Text.StringBuilder [System.Runtime]System.Text.StringBuilder::Append(string)
    IL_0014:  pop
    IL_0015:  ldstr      bytearray (27 04 42 04 3E 04 20 00 32 04 4B 04 20 00 45 04   // '.B.>. .2.K. .E.
                                    3E 04 42 04 38 04 42 04 35 04 20 00 3D 04 30 04   // >.B.8.B.5. .=.0.
                                    39 04 42 04 38 04 20 00 32 04 20 00 47 00 6F 00   // 9.B.8. .2. .G.o.
                                    6F 00 67 00 6C 00 65 00 3F 00 )                   // o.g.l.e.?.
    IL_001a:  call       string Project_before_changes.Program::GetStringFromUser(string)
    IL_001f:  ldc.i4.s   32
    IL_0021:  ldc.i4.s   43
    IL_0023:  callvirt   instance string [System.Runtime]System.String::Replace(char,
                                                                                char)
    IL_0028:  stloc.2
    IL_0029:  ldloc.1
    IL_002a:  ldloc.2
    IL_002b:  callvirt   instance class [System.Runtime]System.Text.StringBuilder [System.Runtime]System.Text.StringBuilder::Append(string)
    IL_0030:  pop
    IL_0031:  newobj     instance void [System.Runtime]System.Random::.ctor()
    IL_0036:  stloc.3
    IL_0037:  ldloc.3
    IL_0038:  ldc.i4.0
    IL_0039:  ldc.i4.3
    IL_003a:  callvirt   instance int32 [System.Runtime]System.Random::Next(int32,
                                                                            int32)
    IL_003f:  stloc.s    V_4
    IL_0041:  ldstr      ""
    IL_0046:  stloc.s    V_5
    IL_0048:  ldloc.s    V_4
    IL_004a:  stloc.s    V_7
    IL_004c:  ldloc.s    V_7
    IL_004e:  stloc.s    V_6
    IL_0050:  ldloc.s    V_6
    IL_0052:  switch     ( 
                          IL_0065,
                          IL_006e,
                          IL_0077)
    IL_0063:  br.s       IL_0080

    IL_0065:  ldstr      "https://www.ptc.com/en/blogs/cad/beginner-guide-ge"
    + "nerative-design"
    IL_006a:  stloc.s    V_5
    IL_006c:  br.s       IL_0080

    IL_006e:  ldstr      "https://primer.dynamobim.org/en/"
    IL_0073:  stloc.s    V_5
    IL_0075:  br.s       IL_0080

    IL_0077:  ldstr      "https://thebuildingcoder.typepad.com/"
    IL_007c:  stloc.s    V_5
    IL_007e:  br.s       IL_0080

    IL_0080:  ldstr      "chrome.exe"
    IL_0085:  ldloc.s    V_5
    IL_0087:  call       class [System.Diagnostics.Process]System.Diagnostics.Process [System.Diagnostics.Process]System.Diagnostics.Process::Start(string,
                                                                                                                                                    string)
    IL_008c:  pop
    IL_008d:  ret
  } // end of method Program::Main

  .method private hidebysig static string 
          GetStringFromUser(string messageToUser) cil managed
  {
    // Размер кода:       18 (0x12)
    .maxstack  1
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0007:  nop
    IL_0008:  call       string [System.Console]System.Console::ReadLine()
    IL_000d:  stloc.0
    IL_000e:  br.s       IL_0010

    IL_0010:  ldloc.0
    IL_0011:  ret
  } // end of method Program::GetStringFromUser

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Project_before_changes.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\Users\Public\Geekbrains\Введение_в_C#\Lesson_7\Урок_7\Project_after_changes_ildasm\Project_after_changes_ildasm.res
