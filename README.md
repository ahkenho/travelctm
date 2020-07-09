# travelctm
repo for travel CTM code interview

Issue with the SSL certificate validation. Need to enable CORS in the API. To just get the client apps working, change couple things to get the client app to work as below::

The communication between the api and client would work if to drop the https applicationUrl from both api and client in the LaunchSettings.json.

Also need to alter the Index.cshtml page in the client app to display the result correctly. Such as:

@foreach(var item in Model.FizzBuzz)
{
    <span>@item</span>
}

Last, add [BindProperty(SupportsGet = true)] attribute to the InputNum property in the Index.cshtml.cs file. This enable the magic of model binding for get action.
