#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\LessonTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429f8c8df20787a29b82fb93e2f2a42fe6d1b97d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LessonTypes_Index), @"mvc.1.0.view", @"/Views/LessonTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LessonTypes/Index.cshtml", typeof(AspNetCore.Views_LessonTypes_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS;

#line default
#line hidden
#line 2 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429f8c8df20787a29b82fb93e2f2a42fe6d1b97d", @"/Views/LessonTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_LessonTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 373, true);
            WriteLiteral(@"<div id=""topNavigationInterfaceContainer""></div>
<table border=""1"">
    <thead>
        <tr>
            <th><h5><b>#</b></h5></th>
            <th><h5><b>Lesson type name</b></h5></th>
            <th><h5><b>Visibility</b></h5></th>
        </tr>
    </thead>
    <tbody id=""dataTableBody""></tbody>
</table>
<div id=""bottomNavigationInterfaceContainer""></div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(390, 6692, true);
                WriteLiteral(@"
    <style>
        #bottomNavigationInterfaceContainer,
        #topNavigationInterfaceContainer {
            min-height: 70px;
            max-height: 90px;
            border: 2px solid black;
        }

        table {
            width: 100%;
            margin-bottom: 10px;
            margin-top: 10px;
        }

        td {
            border: 3px solid black;
            padding: 3px;
            text-align: left;
        }
    </style>
    <script>
        let pageSize = 5;//Fixed the page size to 5 per page
        //Call the loadData to begin making GET HTTP request
        //which fetches the first 5 record data for page 1
        loadData();
        function loadData() {
            //The URL in this ajax method call shall be evaluated as:
            //'/API/LessonTypes/GetLessonTypesPageByPage?page_number=1&per_page=5'
            //The technique used is called ""interpolation"".
            //Notice that I did not use + string concatenation.
            //The H");
                WriteLiteral(@"TTP request aims to fetch the first 5 records which can fit into the
            //page number 1.
            $.ajax({
                method: 'GET',
                url:
                    `/API/LessonTypes/GetLessonTypesPageByPage?page_number=1&per_page=${pageSize}`,
                dataType: 'json',
                async: true,
                cache: false,
            }).done(function (data) {
                let maximumNumberOfPages = data.last_page;
                let numberOfRecords = data.total;
                if (numberOfRecords > 0) {
                    //Call the renderData function and pass the array of objects into the function
                    renderData(data.records);
                    //Call the createNavigationButtonsAtTopFunction
                    //and pass the max num of pages value into the function
                    createNavigationButtonsAtTop(maximumNumberOfPages);
                } else {
                    $('#dataTableBody').append($(`<tr colspan=""3""");
                WriteLiteral(@">
<td><h4>No records found.</h4></td></tr>`));
                }//End of if else to either display rows of data or display 'none found' message
            });//End of ajax().done()
        }//End of loadData
        function renderData(inRecords) {
            $('#dataTableBody').html('');//Clear the <tbody> element first
            for (var i = 0; i < inRecords.length; i++) {
                let record = inRecords[i];//Use the record variable to reference the object in the array
                //The for-loop code here begins building and inserting the cells<td> and rows<tr>
                //into the <tbody> element.
                let $cellElement = null;
                //Start --- Defining the row element to hold
                //the rowNumber, lessonTypeName and isVisible field information
                let $rowElement = $('<tr></tr>');
                $cellElement = $(`<td>${record.rowNumber}</td>`);
                $rowElement.append($cellElement);
                $cellElement =");
                WriteLiteral(@" $(`<td>${record.lessonTypeName}</td>`);
                $rowElement.append($cellElement);
                $cellElement = $(`<td>${record.isVisible}</td>`);
                $rowElement.append($cellElement);
                $('#dataTableBody').append($rowElement);//inserting a new row
                //End-- Defining the row element to hold lesson type information
            }//End of for loop
        }//End of renderData function
        function createNavigationButtonsAtTop(inMaximumNumOfPages) {
            $('#topNavigationInterfaceContainer').text('');
            for (let count = 1; count <= inMaximumNumOfPages; count++) {
                //Create an <a> element which has two HTML data attributes.
                //data-page-number and data-page-size. Associate the count value
                //and the maximum number of record data per page information
                //to the respective attributes.
                let $pageNumberButtonLinkElement =
                    $(`<a href=\""#\"" d");
                WriteLiteral(@"ata-page-number=""${count}""data-page-size=""${pageSize}"" class=""btn btn-secondary"" >${count}</a>&nbsp;`);
                //Register an anonymous function to handle the element's
                //click event
                $pageNumberButtonLinkElement.on('click', function (event) {
                    event.preventDefault();
                    //The event object describes the event which occurred.
                    //The target property represents the element which was clicked.
                    //The $(event.target) expression creates a jQuery object which take control the
                    //<a> which was clicked. For example, if page number button 3 is clicked,
                    //the event.target represents that <a> element which is clicked.
                    //$(event.target) takes control the <a> element which is clicked.
                    //The logic needs the page number value and the page size value from the
                    //respective <a> element which is clicked.
    ");
                WriteLiteral(@"                //Therefore, you can use the $(event.target)data(....) to extract out the
                    //data - page - number and data-page-size attribute value.
                    //$(event.target).data('page-number') extracts the HTML data attribute information
                    let pageSize = $(event.target).data('page-size');
                    //if button 3 is clicked, the .data('page-number') will give 3
                    let pageNumber = $(event.target).data('page-number');
                    //Make a HTTP GET request using the URL which has query string data.
                    $.ajax({
                        method: ""GET"",
                        url: `/API/LessonTypes/GetLessonTypesPageByPage?page_number=${pageNumber}&per_page=${pageSize}`,
                        dataType: ""json"",
                        async: true,
                        cache: false
                    }).done(function (data) {
                        //Call the renderData and pass in the array of ");
                WriteLiteral(@"record data
                        renderData(data.records);
                    })//End of ajax().done()
                });//End of .on('click', function{....})
                //Insert the created <a> element which has a function registered to its click event
                //into the parent <div> element, topNavigationInterfaceContainer
                $('#topNavigationInterfaceContainer').append($pageNumberButtonLinkElement);
            }//End of for loop
        }//End of createNavigationButtonsAtTop function
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
