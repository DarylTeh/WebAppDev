#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\DateTimeSettings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e28fc6bcc221bb72f9562e2cc30949b54be127c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DateTimeSettings_Index), @"mvc.1.0.view", @"/Views/DateTimeSettings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DateTimeSettings/Index.cshtml", typeof(AspNetCore.Views_DateTimeSettings_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e28fc6bcc221bb72f9562e2cc30949b54be127c", @"/Views/DateTimeSettings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_DateTimeSettings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dataForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 254, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header stylish-color-dark white-text\">\r\n        <h4 class=\"one\" style=\"padding-top:1.8%;\">Set current date and time for testing</h4>\r\n    </div>\r\n    <div class=\"card-body\" style=\"padding:3% 5%\">\r\n\r\n        ");
            EndContext();
            BeginContext(307, 2737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2013e0b0c4af417a9dc86dd42ad22430", async() => {
                BeginContext(327, 89, true);
                WriteLiteral("\r\n            <div class=\"form-group col-md-12\">\r\n                <div class=\"md-form\">\r\n");
                EndContext();
                BeginContext(452, 401, true);
                WriteLiteral(@"                    <label for=""yearInput"" class=""font-weight-medium"">Year</label>
                    <input type=""text"" id=""yearInput"" name=""yearInput"" class=""form-control""
                           maxlength=""4"" value=""2019"" />
                    <span></span>
                </div>
            </div>
            <div class=""form-group col-md-12"">
                <div class=""md-form"">
");
                EndContext();
                BeginContext(890, 403, true);
                WriteLiteral(@"                    <label for=""monthInput"" class=""font-weight-medium"">Month</label>
                    <input type=""text"" id=""monthInput"" name=""monthInput"" class=""form-control""
                           maxlength=""2"" value=""9""  />
                    <span></span>
                </div>
            </div>
            <div class=""form-group col-md-12"">
                <div class=""md-form"">
");
                EndContext();
                BeginContext(1328, 392, true);
                WriteLiteral(@"                    <label for=""dayInput"" class=""font-weight-medium"">Day</label>
                    <input type=""text"" id=""dayInput"" name=""dayInput"" class=""form-control""
                           maxlength=""2"" value=""1"" />
                    <span></span>
                </div>
            </div>
            <div class=""form-row col-md-12"">
                <div class=""md-form"">
");
                EndContext();
                BeginContext(1756, 396, true);
                WriteLiteral(@"                    <label for=""dayInput"" class=""font-weight-medium"">Hour</label>
                    <input type=""text"" id=""hourInput"" name=""hourInput"" class=""form-control""
                           maxlength=""2"" value=""14"" />
                    <span></span>
                </div>
            </div>
            <div class=""form-row col-md-12"">
                <div class=""md-form"">
");
                EndContext();
                BeginContext(2188, 429, true);
                WriteLiteral(@"                    <label for=""dayInput"" class=""font-weight-medium"">Minute</label>
                    <input type=""text"" id=""minuteInput"" name=""minuteInput"" class=""form-control""
                           maxlength=""2"" value=""0""/>
                    <span></span>
                </div>
            </div>


            <div class=""form-row col-md-12"">
                <label class=""control-label col-md-1""></label>
");
                EndContext();
                BeginContext(2664, 373, true);
                WriteLiteral(@"                <div class=""float-right"">

                    <button type=""button"" id=""mockupFackDateTimeButton"" class=""btn btn-primary"">Mock up current date time</button>
                    <button type=""button"" id=""setupActualDateTimeButton"" class=""btn btn-primary"">Setup actual current date time</button>



                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3044, 141, true);
            WriteLiteral("\r\n    </div><!-- end of div element which has the class=\"card-body\" -->\r\n</div><!-- end of the div element which has the class=\"card\" -->\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3202, 6863, true);
                WriteLiteral(@"
    <style>
        /*Set colours of error and valid messages on validation*/
        .error {
            color: red;
            font-size: small
        }

        .valid {
            color: green;
            font-size: small
        }

        body {
            margin-top: 30px;
        }
    </style>
    <script>
        setupWebForm();
        //Override jquery validate plugin defaults to show validation status of input boxes
        $.validator.setDefaults({
            highlight: function (element) {
                $(element).closest('.form-group').removeClass('valid').addClass('error')
                $(element).css('border-bottom', '2px solid red');
            },
            unhighlight: function (element) {
                $(element).closest('.form-group').removeClass('error').addClass('valid');
                $(element).css('border-bottom', '2px solid #2ab934'); //green border

            },
            errorElement: 'span',
            errorPlacement: functi");
                WriteLiteral(@"on (error, element) {
                if (element.parent('.input-group').length) {
                    error.insertAfter(element.parent());
                } else {
                    error.insertAfter(element);
                }
            }
        });

        function setupWebForm() {


            jQuery.ajax({
                type: 'GET',
                url: '/api/DateTimeSettings/GetSystemDateTime'

            }).done(function (data, textStatus, jqXHR) {
                let currentDateTime = new Date(data.currentDateTime);
                $('#yearInput').val(currentDateTime.getFullYear());
                $('#monthInput').val(currentDateTime.getMonth()+1);//January gives 0
                $('#dayInput').val(currentDateTime.getDate());
                $('#hourInput').val(currentDateTime.getHours());
                $('#minuteInput').val(currentDateTime.getMinutes());

            }).fail(function (data, textStatus, jqXHR) {
                console.log(textStatus);
         ");
                WriteLiteral(@"       console.log(data);
                new Noty({
                    text: data.responseJSON.message,
                    theme: 'metroui',
                    layout: 'bottomRight',
                    timeout: 3000,
                    type: 'error'
                }).show();
            });//end of ajax


        }

        //Set jquery validation rules
        $('#dataForm').validate({
            rules: {
            },
            messages: {
                yearInput: {
                    required: ""Year is required"",
                },
                monthInput: {
                    required: ""Year is required"",
                },
                dayInput: {
                    required: ""Day is required"",
                },
                hourInput: {
                    required: ""Hour is required"",
                },
                hourInput: {
                    required: ""Minute is required"",
                }
            }
        });





      ");
                WriteLiteral(@"  //Create method to store webform data
        function WebFormData(inYear,inMonth,inDay,inHour,inMinute) {
            this.year = inYear;
            this.month = inMonth;
            this.day = inDay;
            this.hour = inHour;
            this.minute = inMinute;
        }

        //Create method to submit form with POST API method
        $('#mockupFackDateTimeButton').on('click', function () {
            $('#dataForm').validate();
            if ($(""#dataForm"").valid()) {

               

                var webFormData = new WebFormData($('#yearInput').val(), $('#monthInput').val(),
                    $('#dayInput').val(), $('#hourInput').val(),
                $('#minuteInput').val());



               jQuery.ajax({
                    type: 'POST',
                   url: '/api/DateTimeSettings/MockupDateTimeForTesting',
                    contentType: 'application/x-www-form-urlencoded',
                    data: webFormData
                }).done(function (dat");
                WriteLiteral(@"a, textStatus, jqXHR) {
                    new Noty({
                        text: data.message,
                        theme: 'metroui',
                        layout: 'bottomRight',
                        timeout: 1200,
                        type: 'success'
                    }).show();
                    

                }).fail(function (data, textStatus, jqXHR) {
                    console.log(textStatus);
                    console.log(data);
                    new Noty({
                        text: data.responseJSON.message,
                        theme: 'metroui',
                        layout: 'bottomRight',
                        timeout: 3000,
                        type: 'error'
                    }).show();
                });//end of ajax

            }//end of if ($(""#dataForm"").valid()) {

        });//end of $('#mockupFackDateTimeButton').on('click', function () {
        //Create method to submit form with POST API method
        $('#setupActualD");
                WriteLiteral(@"ateTimeButton').on('click', function () {
            $('#dataForm').validate();
            if ($(""#dataForm"").valid()) {



                var webFormData = new WebFormData($('#yearInput').val(), $('#monthInput').val(),
                    $('#dayInput').val(), $('#hourInput').val(),
                    $('#minuteInput').val());



                jQuery.ajax({
                    type: 'POST',
                    url: '/api/DateTimeSettings/SetupActualDateTime',
                    contentType: 'application/x-www-form-urlencoded',
                    data: webFormData
                }).done(function (data, textStatus, jqXHR) {
                    new Noty({
                        text: data.message,
                        theme: 'metroui',
                        layout: 'bottomRight',
                        timeout: 1200,
                        type: 'success'
                    }).show();


                }).fail(function (data, textStatus, jqXHR) {
                   ");
                WriteLiteral(@" console.log(textStatus);
                    console.log(data);
                    new Noty({
                        text: data.responseJSON.message,
                        theme: 'metroui',
                        layout: 'bottomRight',
                        timeout: 3000,
                        type: 'error'
                    }).show();
                });//end of ajax

            }//end of if ($(""#dataForm"").valid()) {

        });//end of $('#setupActualDateTimeButton').on('click', function () {

        $('#monthInput').focus();
        $('#dayInput').focus();
        $('#hourInput').focus(),
        $('#minuteInput').focus();
        $('#yearInput').focus()

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