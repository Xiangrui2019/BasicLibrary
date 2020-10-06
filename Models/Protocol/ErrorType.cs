namespace BasicLibrary.Models.Protocol
{
    /**
     * 错误码:
     * - "0" 为成功
     * - "+x" 为失败, 且原因是用户输入错误
     * - "-x" 为失败, 且原因是服务器本身错误
     */
    public enum ErrorType
    {
        Success = 0,
        
    }
}