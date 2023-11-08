namespace Yangxj96.Serve.Common.Response;

public static class RStatus
{
    public readonly struct ResponseStatus
    {
        public int Code { get; }
        public string Msg { get; }

        public ResponseStatus(int code, string msg)
        {
            Code = code;
            Msg = msg;
        }

        public override string ToString() => $"code:{Code},msg:{Msg}";
    }

    public static readonly ResponseStatus Failure = new(-1, "����ʧ��");
    public static readonly ResponseStatus Success = new(0, "����ɹ�");

    public static readonly ResponseStatus DataExistFailure    = new(0, "�����Ѵ���");
    public static readonly ResponseStatus DataNotExistFailure = new(0, "���ݲ�����");
    public static readonly ResponseStatus DataInsertFailure   = new(0, "���ݲ���ʧ��");
    public static readonly ResponseStatus DataDeleteFailure   = new(0, "����ɾ��ʧ��");
    public static readonly ResponseStatus DataUpdateFailure   = new(0, "���ݸ���ʧ��");
    public static readonly ResponseStatus DataQueryFailure    = new(0, "���ݲ�ѯʧ��");
}