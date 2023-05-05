#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\CustomerAccounts\AssignInstructors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "944a29d2d1ca95f40581ad735d44afcb0e704baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerAccounts_AssignInstructors), @"mvc.1.0.view", @"/Views/CustomerAccounts/AssignInstructors.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerAccounts/AssignInstructors.cshtml", typeof(AspNetCore.Views_CustomerAccounts_AssignInstructors))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944a29d2d1ca95f40581ad735d44afcb0e704baf", @"/Views/CustomerAccounts/AssignInstructors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerAccounts_AssignInstructors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1028, true);
            WriteLiteral(@"<div class=""card col-30"">
    <div class=""card-header elegant-color white-text"">
        <div class=""container-fluid"">
            <div class=""row vertical-align"">
                <h3 style=""padding-top:11px;"">Assign instructor(s) to customer</h3>
                <button id=""buttonManage"" type=""button"" class=""btn btn-elegant btn-outline-default btn-group-sm ml-auto"" data-toggle=""modal"" data-target=""#aboutModal"">
                    Manage Instructor
                </button>
            </div>
        </div>
    </div>
</div>
<h3 style=""padding-top:11px;"" id=""custName""></h3>
<button id=""btnAssigned"" class=""btn btn-primary col-sm-offset-8"" disabled>Submit</button>

<div id=""pageButtons"" class='btn-group'></div>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th></th>
            <th></th>
            <th>Full Name</th>
            <th>Email</th>
            <th>Accounts</th>
        </tr>
    </thead>

    <tbody id=""info""></tbody>
</table>
");
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1045, 7412, true);
                WriteLiteral(@"
    <script>
        const ID = getIdFromAddressBar();
        // Get id from address bar
        function getIdFromAddressBar() {
            let urlArray = window.location.href.split('/');
            let id = urlArray[urlArray.length - 1];
            return id;
        };

        getCustomerName();
        function getCustomerName() {
            $.ajax({
                method: 'GET',
                url: ""/API/CustomerAccounts/"" + ID
            }).done(function (data) {
                $(""#custName"").text(data.accountName);
            }).fail(function (data) {
                new Noty({ text: data.responseJSON.message, type: 'error' }).show();
            })
        }

        function genStdRateInput() {

            listBoxElement = $('<select class=""form-control"" disabled><option value=""0"">--Select wage rate--</select>');

            for (let rate = 50; rate <= 2000; rate = rate + 50) {
                listBoxElement.append($(`<option value=${rate}>${rate}</option>`));");
                WriteLiteral(@"
            }
            return listBoxElement;
        }
        firstLoadIntstructors();
        function firstLoadIntstructors() {
            $.ajax({
                method: 'GET',
                url: `/api/Instructor/GetAllInstructor/${ID}?pgNo=1&pgSize=7`
            }).done(function (data) {
                console.log(data);

                //Generate the page navigation
                generatePageButton(data.totalPageCnt);

                //Generate the table content
                updateHTMLTable(data.records);

            }).fail(function (data) {

                new Noty({ text: data.responseJSON.message, type: 'error' }).show();
            })
        }

        function loadInstructorByPage(pageNo) {
            $.ajax({
                method: 'GET',
                url: `/api/Instructor/GetAllInstructor/${ID}?pgNo=${pageNo}&pgSize=7`
            }).done(function (data) {
                console.log(data);

                //Generate the table content
 ");
                WriteLiteral(@"               updateHTMLTable(data.records);

            }).fail(function (data) {
                new Noty({ text: data.responseJSON.message, type: 'error' }).show();
            })
        }

        function generatePageButton(lastPageNum) {
            navElements = $(""#pageButtons"").empty();
            for (var pageNo = 1; pageNo <= lastPageNum; pageNo++) {
                newElement = `<button class='btn btn btn-secondary' onclick='loadInstructorByPage(${pageNo})'>${pageNo}</button>&nbsp;`;
                navElements.append(newElement);
            }
        }

        function updateHTMLTable(instructorData) {
            tableElement = $('#info').empty();

            for (let i = 0; i < instructorData.length; i++) {
                let cellElement = null;
                let oneInstr = instructorData[i];
                let checkBoxElement = $('<td text-align:center></td>').append($('<input>',
                    {
                        type: 'radio',
                   ");
                WriteLiteral(@"     'checked': false,
                        name: 'instructorSelect',
                        value: oneInstr.id
                    })); //end of let checkBoxElement

                let rowElement = $('<tr></tr>');

                if (oneInstr.assignToCustomer) {
                    cellElement = $('<td data-sort=""image1""><i class= ""fas fa-check mr-1"">')
                    rowElement.append(cellElement);
                } else {
                    cellElement = checkBoxElement;
                }
                rowElement.append(cellElement);

                // Generating the Select Box
                selectElement = genStdRateInput();
                selectElement.val(oneInstr.rate);
                rowElement.append($('<td></td>')
                    .append(selectElement)
                    .append('<div id=""' + oneInstr.id + '""class=""text-danger""></div>'));

                cellElement = $(`<td>${oneInstr.fullName}</td>`);
                rowElement.append(cellElement);
");
                WriteLiteral(@"                cellElement = $(`<td>${oneInstr.email}</td>`);
                rowElement.append(cellElement);

                extCellElement = $(""<td><ul></ul></td>"");
                for (let k = 0; k < oneInstr.custAss.length; k++) {
                    console.log(oneInstr.custAss[k]);
                    intCellElement = $(`<li>${oneInstr.custAss[k]}</li>`)
                    extCellElement.append(intCellElement);
                }
                rowElement.append(extCellElement);

                console.log("">>>"");
                tableElement.append(rowElement);
            }
            // Enable wage selection when radio clicked
            $('input[name = instructorSelect]').click('on', function () {
                notSelectedRadioElement = $('input[name = instructorSelect]');
                notSelectedRadioElement.parent().parent().find('select').prop('disabled', true);
                selectedRadioElement = $('input[name = instructorSelect]:checked');
                selec");
                WriteLiteral(@"tedRadioElement.parent().parent().find('select').prop('disabled', false);

                $('.text-danger').text('');
                $('#btnAssigned').prop('disabled', false);
            })
        } // function updateHTMLTable
        // Web form data object method
        function WebFormData(inInstructorId, inWageRate, inCustomerId) {
            this.instructorId = inInstructorId;
            this.wageRate = inWageRate;
            this.custId = inCustomerId;
        }

        $('#btnAssigned').click('on', function () {
            //To show the how to retreive the value from the radio button and select box
            selectedRadioElement = $('input[name = instructorSelect]:checked');

            radioElementValue = selectedRadioElement.val();
            selectElementValue = selectedRadioElement.parent().parent().find('select').val();

            let webFormData = new WebFormData(radioElementValue, selectElementValue, ID);

            console.dir(webFormData);

           ");
                WriteLiteral(@" if (selectElementValue == 0) {
                console.dir(""null lul"");
                $(`#${radioElementValue}`).text(""Please provide a wage rate"");
            } else {
                $.ajax({
                    method: 'POST',
                    url: '/API/Instructor',
                    datatype: 'json',
                    contentType: 'application/x-www-form-urlencoded;charset=UTF-8',
                    data: webFormData
                }).done(function (data) {
                    new Noty({
                        text: data.message,
                        type: 'success',
                        layout: 'center',
                        timeout: 1500
                    }).show();
                    firstLoadIntstructors();

                }).fail(function (data) {
                    new Noty({
                        text: data.responseJSON.message, type: 'error',
                        layout: 'center',
                        timeout: 2500
                    })");
                WriteLiteral(".show();\r\n                })\r\n            }\r\n        })\r\n\r\n        // Go to index\r\n        $(\'#buttonManage\').click(function () {\r\n            window.location = \'/CustomerAccounts/ManageInstructorAssignment/\' + ID;\r\n        });\r\n    </script>\r\n");
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