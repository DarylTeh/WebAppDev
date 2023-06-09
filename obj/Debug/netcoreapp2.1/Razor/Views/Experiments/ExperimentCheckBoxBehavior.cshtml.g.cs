#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Experiments\ExperimentCheckBoxBehavior.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2903d4edeaa29cbdb6f78b3c22a7a4c60f487215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experiments_ExperimentCheckBoxBehavior), @"mvc.1.0.view", @"/Views/Experiments/ExperimentCheckBoxBehavior.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Experiments/ExperimentCheckBoxBehavior.cshtml", typeof(AspNetCore.Views_Experiments_ExperimentCheckBoxBehavior))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2903d4edeaa29cbdb6f78b3c22a7a4c60f487215", @"/Views/Experiments/ExperimentCheckBoxBehavior.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_Experiments_ExperimentCheckBoxBehavior : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 3795, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""card col-12"">

        <div class=""card-header elegant-color white-text"">
            <div class=""container-fluid"">
                <div class=""row vertical-align"">
                    <h3 class=""one"" style=""padding-top:8px;"">Experiment checkbox behavior</h3>
                    <button type=""button"" class=""btn btn-elegant btn-outline-default btn-group-sm ml-auto"" data-toggle=""modal"" data-target=""#aboutModal"">
                        About this experiment
                    </button>
                </div>
            </div>
        </div>
    </div>

    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-md-12"">
                
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""float-right"">
                    <button type=""button"" id=""deleteButton1"" class=""btn btn-primary"">
                        Delete
                    </button>
        ");
            WriteLiteral(@"            <button type=""button"" class=""btn btn-light"" href=""##"" onClick=""history.go(-1); return false;"">Back</button>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""table-responsive-md w-100"">
                <div id=""dataTopNavigationContainer"" class=""btn-toolbar float-right"" role=""toolbar""></div>
                <table id=""dataTableContainer"" class=""table table-bordered"">
                    <thead><tr><th></th><th>Full name</th><th>Email</th><th>Registration date/time</th></tr></thead>
                    <tbody id=""dataTableBody""></tbody>

                </table>
                <div id=""dataBottomNavigationContainer"" class=""btn-toolbar float-right"" role=""toolbar""></div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""float-right"">
                    <button type=""button"" id=""deleteButton2"" class=""btn btn-primary"">
                        Delete
  ");
            WriteLiteral(@"                  </button>
                    <button type=""button"" class=""btn btn-light"" href=""##"" onClick=""history.go(-1); return false;"">Back</button>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""aboutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""aboutModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""aboutModalLabel"">About Manage Instructor Functionality</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <ul>
                    <li><h6>To find out how checkboxes can be dynamically created using JavaScript</h6></li>
                    <li><h6>How each checkb");
            WriteLiteral(@"oxes can have values (representing record id)</h6></li>
                    <li>
                        <h6>
                           How to collect values from the checkboxes which are checked (selected)
                        </h6>
                        <div class=""text-muted font-small"">This influences how data is collected and sent to the Web API. This also influences how Web API method should be declared to accept these values</div>
                    </li>
                </ul>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3858, 3905, true);
                WriteLiteral(@"

    <style>
        body {
            margin-top: 30px;
            padding-right: 0px;
        }

        .empty-row {
            background: #BBB;
            background-image: radial-gradient(black 2%, transparent 0), radial-gradient(black 5%, transparent 0);
            background-size: 5px 5px;
            background-position: 0 0, 15px 15px;
        }
    </style>

    <script>

        (function ($, moment,window) {
            loadData();
            function loadData() {
                //Prepare mock-up data , fake data
                let data = {
                    records: [
                    { recordId: 11, fullName: 'BETSY', email: 'betsy@happercoder.com', registrationDate: '2019-06-30T11:25:50' },
                    { recordId: 12, fullName: 'BEN', email: 'ben@happercoder.com', registrationDate: '2019-04-01T07:35:50' },
                    { recordId: 13, fullName: 'TOM', email: 'tom@happercoder.com', registrationDate: '2019-03-09T15:12:50' },
               ");
                WriteLiteral(@"     { recordId: 14, fullName: 'NANCY', email: 'nancy@happercoder.com', registrationDate: '2019-07-10T21:11:50' },
                    { recordId: 15, fullName: 'BOB', email: 'bob@happercoder.com', registrationDate: '2019-06-21T08:38:50' }
                    ]
                };
                 renderData(data.records,window);
            }//loadData

            function renderData(records, window) {
                let doc = window.document;
                $(doc.getElementById('dataTableBody')).html('');
                    for (var i = 0; i < records.length; i++) {
                        let $checkboxCellElement = null;
                        let $rowElement = $('<tr></tr>');
                            $checkboxCellElement = $('<td></td>').append($('<input>').attr({
                                type: 'checkbox',
                                name:'recordIdInput',
                                id: `recordIdInput_${ records[i].recordId}`,
                                value: r");
                WriteLiteral(@"ecords[i].recordId
                            }));
                        $rowElement.append($checkboxCellElement);
                        $rowElement.append($(`<td>${records[i].fullName}</td><td>${records[i].email}</td><td>${moment(records[i].registrationDate).format('DD/MM/YYYY hh:mm A')}</td>`));
                        $('#dataTableBody').append($rowElement);
                    }

                /* Quick and dirty trick to enable the button when any checkbox is selected */
                //https://stackoverflow.com/questions/20687884/disable-button-if-all-checkboxes-are-unchecked-and-enable-it-if-at-least-one-is
                let $checkBoxElements = $('input[type=checkbox]');
                console.log($checkBoxElements.filter(':checked').length)
                $checkBoxElements.change(function () {
                    if ($checkBoxElements.filter(':checked').length < 1) {
                        //disable the unassign button
                        $('#deleteButton1,#deleteButton2");
                WriteLiteral(@"').addClass('disabled');
                    } else {
                        //enable the unassign button
                        $('#deleteButton1,#deleteButton2').removeClass('disabled');
                    }
                });
                $checkBoxElements.change(); // or add disabled=""true"" in the HTML
            }//renderData


            $('#deleteButton1,#deleteButton2').on('click', function (event) {
                let $elements = $('input[type=checkbox]:checked');
                let recordIdList = [];
                $elements.each(function () {
                    recordIdList.push($(this).val());
                });
                new Noty({ status: 'info', text: recordIdList.join(','),layout:'center' }).show();
            });


        })($, moment, window)


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
