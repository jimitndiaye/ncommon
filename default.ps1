properties {
  $base_dir = Resolve-Path .
  $build_dir = "$base_dir\build\"
  $libs_dir = "$base_dir\Libs"
  $output_dir = "$base_dir\output\"
  $sln = "$base_dir\NCommon Everything.sln"
  $build_config = ""
  $test_runner = "$libs_dir\nunit\nunit-console.exe"
  $version = "1.1"
}

include .\psake_ext.ps1

Task default -depends debug

Task Clean {
    remove-item -force -recurse $build_dir -ErrorAction SilentlyContinue
    remove-item -force -recurse $output_dir -ErrorAction SilentlyContinue
}

Task Init -depends Clean {
    Generate-Assembly-Info `
		-file "$base_dir\NCommon\src\Properties\AssemblyInfo.cs" `
		-title "NCommon Framework" `
		-description "NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"
   
    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.CastleWindsor\Properties\AssemblyInfo.cs" `
		-title "NCommon Castle Windsor Container Adapter" `
		-description "Castle Windsor Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon.ContainerAdapter.CastleWindsor $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"
        
    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.NInject\Properties\AssemblyInfo.cs" `
		-title "NCommon NInject Container Adapter" `
		-description "NInject Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon.ContainerAdapter.NInject $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"
    
    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.StructureMap\Properties\AssemblyInfo.cs" `
		-title "NCommon StructureMap Container Adapter" `
		-description "StructureMap Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon.ContainerAdapter.StructureMap $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"
        
    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.Unity\Properties\AssemblyInfo.cs" `
		-title "NCommon Unity Container Adapter" `
		-description "Unity Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon.ContainerAdapter.Unity $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.Db4o\src\Properties\AssemblyInfo.cs" `
		-title "NCommon Db4o Provider" `
		-description "Db4o Provider for NCommon Framework" `
		-company "" `
		-product "NCommon.Db4o $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.EntityFramework\src\Properties\AssemblyInfo.cs" `
		-title "NCommon Entity Framework Provider" `
		-description "Entity Framework Provider for NCommon Framework" `
		-company "" `
		-product "NCommon.EntityFramework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"
        
    Generate-Assembly-Info `
		-file "$base_dir\NCommon.LinqToSql\src\Properties\AssemblyInfo.cs" `
		-title "NCommon Linq To Sql Provider" `
		-description "Linq To Sql Provider for NCommon Framework" `
		-company "" `
		-product "NCommon.LinqToSql $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.NHibernate\src\Properties\AssemblyInfo.cs" `
		-title "NCommon NHibernate Provider" `
		-description "NHibernate Provider for NCommon Framework" `
		-company "" `
		-product "NCommon.NHibernate $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"
               
    new-item $build_dir -itemType directory -ErrorAction SilentlyContinue
    new-item $output_dir -itemType directory -ErrorAction SilentlyContinue
}

Task Compile -depends Init {
    Write-Host "Building $sln"
    msbuild $sln /verbosity:minimal "/p:OutDir=$build_dir" "/p:Configuration=$build_config" "/nologo" 
}

Task Test -depends Compile {
    Write-Host "Running tests for NCommon.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.Tests.dll"} "Tests for NCommon.Tests.dll failed!"
    
    Write-Host "Running tests for NCommon.Db4o.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.Db4o.Tests.dll"} "Tests for NCommon.Db4o.Tests.dll failed!"
    
    Write-Host "Running tests for NCommon.EntityFramework.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.EntityFramework.Tests.dll"} "Tests for NCommon.EntityFramework.Tests.dll failed!"
    
    Write-Host "Running tests for NCommon.LinqToSql.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.LinqToSql.Tests.dll"} "Tests for NCommon.LinqToSql.Tests.dll failed!"
    
    Write-Host "Running tests for NCommon.NHibernate.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.NHibernate.Tests.dll"} "Tests for NCommon.NHibernate.Tests.dll failed!"
}
Task Build -depends Test {
    Write-Host "Copying build output to $output_dir"
    $exclude = @('*Test*')
    Copy-Item "$build_dir\NCommon*" -destination $output_dir -Exclude $exclude -ErrorAction SilentlyContinue
}

Task debug {
    $build_config = "Debug"
    $output_dir = "$output_dir$build_config"
    ExecuteTask Build
}

Task release {
    $build_config = "Release"
    $output_dir = "$output_dir$build_config"
    ExecuteTask Build
}