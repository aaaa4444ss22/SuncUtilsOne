using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    /// <summary>
    /// 状态
    /// </summary>
    public enum ResultStatus
    {
        //
        // 摘要:
        //     等效于 HTTP 状态 100。 System.Net.HttpStatusCode.Continue 指示客户端可以继续其请求。
        Continue = 100,
        //
        // 摘要:
        //     等效于 HTTP 状态为 101。 System.Net.HttpStatusCode.SwitchingProtocols 指示正在更改的协议版本或协议。
        SwitchingProtocols = 101,
        //
        // 摘要:
        //     等效于 HTTP 状态 200。 System.Net.HttpStatusCode.OK 指示请求成功，且请求的信息包含在响应中。 这是要接收的最常见状态代码。
        [Description("成功")]
        OK = 200,
        //
        // 摘要:
        //     等效于 HTTP 状态 201。 System.Net.HttpStatusCode.Created 指示请求导致已发送响应之前创建一个新的资源。
        Created = 201,
        //
        // 摘要:
        //     等效于 HTTP 状态 202。 System.Net.HttpStatusCode.Accepted 指示请求已被接受进行进一步处理。
        Accepted = 202,
        //
        // 摘要:
        //     等效于 HTTP 状态 203。 System.Net.HttpStatusCode.NonAuthoritativeInformation 指示返回的元信息来自而不是原始服务器的缓存副本，因此可能不正确。
        NonAuthoritativeInformation = 203,
        //
        // 摘要:
        //     等效于 HTTP 状态 204。 System.Net.HttpStatusCode.NoContent 指示已成功处理请求和响应是有意留为空白。
        [Description("已成功处理请求和响应")]
        NoContent = 204,
        //
        // 摘要:
        //     等效于 HTTP 状态 205。 System.Net.HttpStatusCode.ResetContent 指示客户端应重置 （而不是重新加载） 的当前资源。
        ResetContent = 205,
        //
        // 摘要:
        //     等效于 HTTP 206 状态。 System.Net.HttpStatusCode.PartialContent 指示根据包括字节范围的 GET 请求的请求的响应是部分响应。
        PartialContent = 206,
        //
        // 摘要:
        //     等效于 HTTP 状态 300。 System.Net.HttpStatusCode.MultipleChoices 指示所需的信息有多种表示形式。 默认操作是将此状态视为一个重定向，并按照与此响应关联的位置标头的内容。
        MultipleChoices = 300,
        //
        // 摘要:
        //     等效于 HTTP 状态 300。 System.Net.HttpStatusCode.Ambiguous 指示所需的信息有多种表示形式。 默认操作是将此状态视为一个重定向，并按照与此响应关联的位置标头的内容。
        Ambiguous = 300,
        //
        // 摘要:
        //     等效于 HTTP 状态 301。 System.Net.HttpStatusCode.MovedPermanently 指示已将所需的信息移动到的位置标头中指定的
        //     URI。 当收到此状态时的默认操作是遵循与响应关联的位置标头。
        MovedPermanently = 301,
        //
        // 摘要:
        //     等效于 HTTP 状态 301。 System.Net.HttpStatusCode.Moved 指示已将所需的信息移动到的位置标头中指定的 URI。 当收到此状态时的默认操作是遵循与响应关联的位置标头。
        //     当原始请求方法是 POST 时，重定向的请求将使用 GET 方法。
        Moved = 301,
        //
        // 摘要:
        //     等效于 HTTP 状态 302。 System.Net.HttpStatusCode.Found 指示所需的信息位于的位置标头中指定的 URI。 当收到此状态时的默认操作是遵循与响应关联的位置标头。
        //     当原始请求方法是 POST 时，重定向的请求将使用 GET 方法。
        Found = 302,
        //
        // 摘要:
        //     等效于 HTTP 状态 302。 System.Net.HttpStatusCode.Redirect 指示所需的信息位于的位置标头中指定的 URI。 当收到此状态时的默认操作是遵循与响应关联的位置标头。
        //     当原始请求方法是 POST 时，重定向的请求将使用 GET 方法。
        Redirect = 302,
        //
        // 摘要:
        //     等效于 HTTP 状态 303。 System.Net.HttpStatusCode.SeeOther 自动将客户端重定向到的位置标头中指定作为公告的结果的
        //     URI。 对指定的位置标头的资源的请求将会执行与 GET。
        SeeOther = 303,
        //
        // 摘要:
        //     等效于 HTTP 状态 303。 System.Net.HttpStatusCode.RedirectMethod 自动将客户端重定向到的位置标头中指定作为公告的结果的
        //     URI。 对指定的位置标头的资源的请求将会执行与 GET。
        RedirectMethod = 303,
        //
        // 摘要:
        //     等效于 HTTP 状态 304。 System.Net.HttpStatusCode.NotModified 指示客户端的缓存的副本是最新。 不会传输资源的内容。
        NotModified = 304,
        //
        // 摘要:
        //     等效于 HTTP 状态 305。 System.Net.HttpStatusCode.UseProxy 指示该请求应使用的位置标头中指定的 uri 的代理服务器。
        UseProxy = 305,
        //
        // 摘要:
        //     等效于 HTTP 状态 306。 System.Net.HttpStatusCode.Unused 是对未完全指定的 HTTP/1.1 规范建议的扩展。
        Unused = 306,
        //
        // 摘要:
        //     等效于 HTTP 状态 307。 System.Net.HttpStatusCode.TemporaryRedirect 指示请求信息位于的位置标头中指定的
        //     URI。 当收到此状态时的默认操作是遵循与响应关联的位置标头。 当原始请求方法是 POST 时，重定向的请求还将使用 POST 方法。
        TemporaryRedirect = 307,
        //
        // 摘要:
        //     等效于 HTTP 状态 307。 System.Net.HttpStatusCode.RedirectKeepVerb 指示请求信息位于的位置标头中指定的
        //     URI。 当收到此状态时的默认操作是遵循与响应关联的位置标头。 当原始请求方法是 POST 时，重定向的请求还将使用 POST 方法。
        RedirectKeepVerb = 307,
        //
        // 摘要:
        //     等效于 HTTP 状态 400。 System.Net.HttpStatusCode.BadRequest 指示无法由服务器理解此请求。 System.Net.HttpStatusCode.BadRequest
        //     如果没有其他错误适用，或者如果具体的错误是未知的或不具有其自己的错误代码发送。
        BadRequest = 400,
        //
        // 摘要:
        //     等效于 HTTP 状态 401。 System.Net.HttpStatusCode.Unauthorized 指示所请求的资源需要身份验证。 Www-authenticate
        //     标头包含如何执行身份验证的详细信息。
        Unauthorized = 401,
        //
        // 摘要:
        //     等效于 HTTP 状态 402。 System.Net.HttpStatusCode.PaymentRequired 已保留供将来使用。
        PaymentRequired = 402,
        //
        // 摘要:
        //     等效于 HTTP 状态 403。 System.Net.HttpStatusCode.Forbidden 指示服务器拒绝无法完成请求。
        Forbidden = 403,
        //
        // 摘要:
        //     等效于 HTTP 状态 404。 System.Net.HttpStatusCode.NotFound 指示所请求的资源不存在的服务器上。
        NotFound = 404,
        //
        // 摘要:
        //     等效于 HTTP 状态 405。 System.Net.HttpStatusCode.MethodNotAllowed 指示请求方法 （POST 或 GET）
        //     不允许对所请求的资源。
        MethodNotAllowed = 405,
        //
        // 摘要:
        //     等效于 HTTP 状态 406。 System.Net.HttpStatusCode.NotAcceptable 表示客户端已指定使用 Accept 标头，它将不接受任何可用的资源表示。
        NotAcceptable = 406,
        //
        // 摘要:
        //     等效于 HTTP 状态 407。 System.Net.HttpStatusCode.ProxyAuthenticationRequired 指示请求的代理要求身份验证。
        //     代理服务器进行身份验证标头包含如何执行身份验证的详细信息。
        ProxyAuthenticationRequired = 407,
        //
        // 摘要:
        //     等效于 HTTP 状态 408。 System.Net.HttpStatusCode.RequestTimeout 指示客户端的服务器预期请求的时间内没有未发送请求。
        RequestTimeout = 408,
        //
        // 摘要:
        //     等效于 HTTP 状态 409。 System.Net.HttpStatusCode.Conflict 指示该请求可能不会执行由于在服务器上发生冲突。
        Conflict = 409,
        //
        // 摘要:
        //     等效于 HTTP 状态 410。 System.Net.HttpStatusCode.Gone 指示所请求的资源不再可用。
        Gone = 410,
        //
        // 摘要:
        //     等效于 HTTP 状态 411。 System.Net.HttpStatusCode.LengthRequired 指示缺少必需的内容长度标头。
        LengthRequired = 411,
        //
        // 摘要:
        //     等效于 HTTP 状态 412。 System.Net.HttpStatusCode.PreconditionFailed 表示失败，此请求的设置的条件，无法执行请求。
        //     使用条件请求标头，如果匹配项，如设置条件无-If-match，或如果-修改-自从。
        PreconditionFailed = 412,
        //
        // 摘要:
        //     等效于 HTTP 状态 413。 System.Net.HttpStatusCode.RequestEntityTooLarge 指示请求来说太大的服务器能够处理。
        RequestEntityTooLarge = 413,
        //
        // 摘要:
        //     等效于 HTTP 状态 414。 System.Net.HttpStatusCode.RequestUriTooLong 指示 URI 太长。
        RequestUriTooLong = 414,
        //
        // 摘要:
        //     等效于 HTTP 状态 415。 System.Net.HttpStatusCode.UnsupportedMediaType 指示该请求是不受支持的类型。
        UnsupportedMediaType = 415,
        //
        // 摘要:
        //     等效于 HTTP 416 状态。 System.Net.HttpStatusCode.RequestedRangeNotSatisfiable 指示从资源请求的数据范围不能返回，或者因为范围的开始处，然后该资源的开头或范围的末尾后在资源的结尾。
        RequestedRangeNotSatisfiable = 416,
        //
        // 摘要:
        //     等效于 HTTP 状态 417。 System.Net.HttpStatusCode.ExpectationFailed 指示无法由服务器满足 Expect
        //     标头中给定。
        ExpectationFailed = 417,
        //
        // 摘要:
        //     等效于 HTTP 状态 426。 System.Net.HttpStatusCode.UpgradeRequired 指示客户端应切换到不同的协议，例如
        //     TLS/1.0。
        UpgradeRequired = 426,
        //
        // 摘要:
        //     等效于 HTTP 状态 500。 System.Net.HttpStatusCode.InternalServerError 表示在服务器上发生一般性错误。
        [Description("失败")]
        InternalServerError = 500,
        //
        // 摘要:
        //     等效于 HTTP 状态 501。 System.Net.HttpStatusCode.NotImplemented 指示服务器不支持所请求的功能。
        NotImplemented = 501,
        //
        // 摘要:
        //     等效于 HTTP 状态 502。 System.Net.HttpStatusCode.BadGateway 指示中间代理服务器从另一个代理或原始服务器接收到错误响应。
        BadGateway = 502,
        //
        // 摘要:
        //     等效于 HTTP 状态 503。 System.Net.HttpStatusCode.ServiceUnavailable 指示将服务器暂时不可用，通常是由于高负载或维护。
        ServiceUnavailable = 503,
        //
        // 摘要:
        //     等效于 HTTP 状态 504。 System.Net.HttpStatusCode.GatewayTimeout 指示中间代理服务器在等待来自另一个代理或原始服务器的响应时已超时。
        GatewayTimeout = 504,
        //
        // 摘要:
        //     等效于 HTTP 状态 505。 System.Net.HttpStatusCode.HttpVersionNotSupported 指示服务器不支持请求的
        //     HTTP 版本。
        HttpVersionNotSupported = 505

    }
}
