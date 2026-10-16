# Blazor DataGrid - Custom Adaptor as Component with DataAdaptor<T>

## Overview

This sample demonstrates how to bind a Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) using a custom adaptor implemented as a Blazor component. The custom adaptor is created by extending `OwningComponentBase` and uses the generic `DataAdaptor<T>` implementation to process grid requests. The sample supports Create, Read, Update, and Delete (CRUD) operations together with sorting and filtering, allowing complete control over data processing logic through a strongly typed custom adaptor. This approach is useful when applications require dependency injection, custom business rules, service-based data access, or custom persistence logic beyond the capabilities of built-in DataManager adaptors.

## Key Features

- Implements a custom DataGrid adaptor as a Blazor component.
- Uses the generic `DataAdaptor<T>` implementation for strongly typed data operations.
- Extends `OwningComponentBase` to enable dependency injection within the adaptor component.
- Supports Create, Read, Update, and Delete (CRUD) operations.
- Processes sorting requests through custom adaptor logic.
- Processes filtering requests through custom adaptor logic.
- Demonstrates custom server-side data binding for the Syncfusion Blazor DataGrid.
- Uses a database-backed data source based on the Northwind sample database.
- Shows how application services can be injected and consumed directly within the custom adaptor implementation.
- Demonstrates handling DataManager requests through a reusable adaptor component architecture.
- Provides a flexible foundation for implementing custom business rules during grid data operations.
- Uses custom data access logic instead of built-in DataManager adaptors.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework
- Microsoft SQL Server LocalDB or a compatible SQL Server installation hosting the Northwind database
- Ensure to modify the path of `NORTHWIND.MDF` in `OrderContext.cs` based on your local path before running the sample.

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:  `CustomAdaptorSample/CustomAdaptorSample.sln`
3. Restore all NuGet packages.
4. Update the `NORTHWIND.MDF` database path in `OrderContext.cs`.
5. Set the startup project to:  `CustomAdaptorSample`
6. Build the solution.
7. Run the application using `Ctrl+F5`.
8. Open the local URL displayed by the application after startup.
9. Verify CRUD, sorting, and filtering functionality within the DataGrid.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory.

```bash
cd CustomAdaptorSample
dotnet restore
dotnet run
```

4. Update the `NORTHWIND.MDF` database path in `OrderContext.cs`.
5. Open the local URL displayed in the terminal after startup.
6. Test add, edit, delete, sorting, and filtering actions within the DataGrid interface.

## Project Structure

`CustomAdaptorSample/Pages/` — contains the page that hosts the Syncfusion DataGrid and connects it to the custom adaptor component.

`CustomAdaptorSample/Data/` — contains the custom adaptor implementation, entity models, data access services, and supporting business logic.

`CustomAdaptorSample/Data/OrderContext.cs` — configures database access and contains the Northwind database path required by the sample.

`CustomAdaptorSample/Program.cs` — registers services and dependency injection configuration consumed by the custom adaptor component.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to custom adaptor data binding, visit https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-adaptors/custom-adaptor

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
