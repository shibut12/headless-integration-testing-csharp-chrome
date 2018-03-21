# Headless Integration testing

This repository contains source code for a simple cross platform integration test application using _.net core 2, xUnit.Net, Selenium web driver, and Chrome browser with headless option_.

## Build status

### Master branch
[![Build Status](https://travis-ci.org/shibut12/headless-integration-testing-csharp-chrome.svg?branch=master)](https://travis-ci.org/shibut12/headless-integration-testing-csharp-chrome)

### Development branch
[![Build Status](https://travis-ci.org/shibut12/headless-integration-testing-csharp-chrome.svg?branch=development)](https://travis-ci.org/shibut12/headless-integration-testing-csharp-chrome)

## Environment setup

* Verify _.net core 2x_ is installed

Run command `dotnet --version` in a terminal window, verify the net core version is `2` or above. Follow instructions in microsoft net core downloads page to install/update net core in your machine. [.net core downloads page](https://www.microsoft.com/net/download/windows)

* Verify _Google chrome version_ `59` or above is installed
  * If the computer you are running the tests are have a graphical user interface such as (Windows / Linux/ MAC OSX ) and have Chrome installed.

    Then Navigate to  [chrome://settings/help](chrome://settings/help) on you chrome browser and verify that the __major version__ number is `59` or above.

  * If the computer you are running the tests are __does not__ have a graphical user interface ( E.g. Headless Linux, Headless build agent)

    Run appropriate command to get Chrome version. In a _ubuntu linux_ box you can run `google-chrome --version` to get the version number.

  * If you are running tests in a Headless CI agent such as Travis CI, Circle CI or appVeyor

   Verify that you have included appropriate _environmental setup_ in the configuration `.yml` file. I'm using _TravisCI_ for this repository and you can find the configuration settings this project uses in `/.travis.yml` file [Link to file](https://github.com/shibut12/headless-integration-testing-csharp-chrome/blob/master/.travis.yml)

* Verify [git-scm](https://git-scm.com/) is installed

    If you run `git --version` on a terminal window and you get a version number, you a re good to go, other wise, install Git

## How to run

If your environment is setup appropriately, run following commands to execute tests.

* Clone the git repository

```posh
git clone https://github.com/shibut12/headless-integration-testing-csharp-chrome.git
```

* Restore dependencies

```posh
cd headless-integration-testing-csharp-chrome
dotnet restore
```

* Run Tests

```posh
dotnet test
```

If everything goes well, you will see test results in the terminal.

```posh
C:\shibu\repos\headless-integration-testing-csharp-chrome>dotnet test
Build started, please wait...
Build completed.

Test run for C:\shibu\repos\headless-integration-testing-csharp-chrome\bin\Debug\netcoreapp2.0\HeadLessTest.dll(.NETCoreApp,Version=v2.0)
Microsoft (R) Test Execution Command Line Tool Version 15.6.0-preview-20180109-01
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
[xUnit.net 00:00:00.7196488]   Discovering: HeadLessTest
[xUnit.net 00:00:00.7780174]   Discovered:  HeadLessTest
[xUnit.net 00:00:00.7836419]   Starting:    HeadLessTest
[xUnit.net 00:00:22.7766661]   Finished:    HeadLessTest

Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 23.7058 Seconds
```