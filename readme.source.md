# <img src="https://avatars3.githubusercontent.com/u/36907" height="30px"> ApprovalTests.StatePrinter

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) to allow simple approval of complex models using [StatePrinter](https://github.com/kbilsted/StatePrinter).


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/ApprovalTests.StatePrinter.svg?style=flat)](https://www.nuget.org/packages/ApprovalTests.StatePrinter/)

https://nuget.org/packages/ApprovalTests.StatePrinter/

    PM> Install-Package ApprovalTests.StatePrinter


## Usage

Given a model:

snippet: model

That is verified:

snippet: usage

Will result in this as an approved file:

```
Root = new Turtle(), ref: 0
{
    Name = "jim"
    On = new Turtle()
    {
        Name = "kasper"
        On = new Turtle()
        {
            Name = "llewellyn"
            On = -> 0
        }
    }
}
```


## Links

 * NuGet: https://nuget.org/packages/ApprovalTests.StatePrinter/
 * Build: [![Build Status](https://dev.azure.com/approvals/ApprovalTests.Net.StatePrinter/_apis/build/status/approvals.ApprovalTests.Net.StatePrinter?branchName=master)](https://dev.azure.com/approvals/ApprovalTests.Net.StatePrinter/_build/latest?definitionId=1&branchName=master)