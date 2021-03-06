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

$framework = "4.0"

Task default -depends debug

Task Clean {
    remove-item -force -recurse $build_dir -ErrorAction SilentlyContinue
    remove-item -force -recurse $output_dir -ErrorAction SilentlyContinue
    write-host $fx_version
}

Task Init -depends Clean {
    Generate-Assembly-Info `
		-file "$base_dir\NCommon\src\Properties\AssemblyInfo.cs" `
		-title "NCommon.dll" `
		-description "NCommon Framework Core Library" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.CastleWindsor\Properties\AssemblyInfo.cs" `
		-title "NCommon.ContainerAdapter.CastleWindsor.dll" `
		-description "Castle Windsor Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.NInject\Properties\AssemblyInfo.cs" `
		-title "NCommon.ContainerAdapter.NInject.dll" `
		-description "NInject Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.StructureMap\Properties\AssemblyInfo.cs" `
		-title "NCommon.ContainerAdapter.StructureMap.dll" `
		-description "StructureMap Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.Unity\Properties\AssemblyInfo.cs" `
		-title "NCommon.ContainerAdapter.Unity.dll" `
		-description "Unity Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.ContainerAdapters\NCommon.ContainerAdapter.Autofac\Properties\AssemblyInfo.cs" `
		-title "NCommon.ContainerAdapter.Autofac" `
		-description "Autofac Container Adapter for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.Db4o\src\Properties\AssemblyInfo.cs" `
		-title "NCommon.Db4o.dll" `
		-description "Db4o Provider for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
		-clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.EntityFramework\src\Properties\AssemblyInfo.cs" `
		-title "NCommon.EntityFramework.dll" `
		-description "Entity Framework Provider for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.LinqToSql\src\Properties\AssemblyInfo.cs" `
		-title "NCommon.LinqToSql.dll" `
		-description "Linq To Sql Provider for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

    Generate-Assembly-Info `
		-file "$base_dir\NCommon.NHibernate\src\Properties\AssemblyInfo.cs" `
		-title "NCommon.NHibernate.dll" `
		-description "NHibernate Provider for NCommon Framework" `
		-company "" `
		-product "NCommon Framework $version" `
		-version $version `
		-copyright "Ritesh Rao 2009 - 2010" `
        -clsCompliant "false"

	Generate-Assembly-Info `
			-file "$base_dir\NCommon.Testing\Properties\AssemblyInfo.cs" `
			-title "NCommon.Testing.dll" `
			-description "Helper library for setting up NCommon for unit tests" `
			-company "" `
			-product "NCommon Framework $version" `
			-version $version `
			-copyright "Ritesh Rao 2009 - 2010" `
			-clsCompliant "false"

    new-item $build_dir -itemType directory -ErrorAction SilentlyContinue
    new-item $output_dir -itemType directory -ErrorAction SilentlyContinue
}

Task Compile -depends Init {
    Write-Host "Building $sln"
    msbuild $sln /verbosity:minimal "/p:OutDir=$build_dir" "/p:Configuration=$build_config"`
									"/p:DefineConstants=net40"`
									"/p:TargetFrameworkVersion=$framework" "/p:ToolsVersion=$framework" /nologo #
}

Task Test -depends Compile {
    Write-Host "Running tests for NCommon.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.Tests.dll" /framework:4.0.30319} "Tests for NCommon.Tests.dll failed!"

    Write-Host "Running tests for NCommon.Db4o.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.Db4o.Tests.dll" /framework:4.0.30319} "Tests for NCommon.Db4o.Tests.dll failed!"

    Write-Host "Running tests for NCommon.EntityFramework.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.EntityFramework.Tests.dll" /framework:4.0.30319} "Tests for NCommon.EntityFramework.Tests.dll failed!"

    Write-Host "Running tests for NCommon.LinqToSql.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.LinqToSql.Tests.dll" /framework:4.0.30319} "Tests for NCommon.LinqToSql.Tests.dll failed!"

    Write-Host "Running tests for NCommon.NHibernate.Tests.dll"
    exec {&$test_runner /nologo "$build_dir\NCommon.NHibernate.Tests.dll" /framework:4.0.30319} "Tests for NCommon.NHibernate.Tests.dll failed!"
}


Task Build -depends Test {
    Write-Host "Copying build output to $output_dir"
    $exclude = @("NCommon.Tests.*", "NCommon.Db4o.Tests.*", "NCommon.EntityFramework.Tests.*", "NCommon.LinqToSql.Tests.*", "NCommon.NHibernate.Tests.*")
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

function Generate-Assembly-Info
{
	param(
		[string]$clsCompliant = "true",
		[string]$title,
		[string]$description,
		[string]$company,
		[string]$product,
		[string]$copyright,
		[string]$version,
		[string]$file = $(throw "file is a required parameter.")
	)
	  $asmInfo = "using System;
	using System.Reflection;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;

	[assembly: CLSCompliantAttribute($clsCompliant )]
	[assembly: ComVisibleAttribute(false)]
	[assembly: AssemblyTitleAttribute(""$title"")]
	[assembly: AssemblyDescriptionAttribute(""$description"")]
	[assembly: AssemblyCompanyAttribute(""$company"")]
	[assembly: AssemblyProductAttribute(""$product"")]
	[assembly: AssemblyCopyrightAttribute(""$copyright"")]
	[assembly: AssemblyVersionAttribute(""$version"")]
	[assembly: AssemblyInformationalVersionAttribute(""$version"")]
	[assembly: AssemblyFileVersionAttribute(""$version"")]
	[assembly: AssemblyDelaySignAttribute(false)]
	"

		$dir = [System.IO.Path]::GetDirectoryName($file)
		if ([System.IO.Directory]::Exists($dir) -eq $false)
		{
			Write-Host "Creating directory $dir"
			[System.IO.Directory]::CreateDirectory($dir)
		}
		Write-Host "Generating assembly info file: $file"
		Write-Output $asmInfo > $file
}