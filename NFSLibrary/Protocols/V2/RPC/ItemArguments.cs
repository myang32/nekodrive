/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V2.RPC
{
    public class ItemArguments : XdrAble
    {
        private NFSHandle _item;
        private NFSCookie _cookie;
        private int _count;

        public ItemArguments()
        { }

        public ItemArguments(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            this._item.xdrEncode(xdr);
            this._cookie.xdrEncode(xdr);
            xdr.xdrEncodeInt(this._count);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._item = new NFSHandle();
            this._item.Version = V2.RPC.NFSv2Protocol.NFS_VERSION;
            this._item.xdrDecode(xdr);
            this._cookie = new NFSCookie(xdr);
            this._count = xdr.xdrDecodeInt();
        }

        public NFSHandle HandleObject
        {
            get
            { return this._item; }
            set
            { this._item = value; }
        }

        public NFSCookie Cookie
        {
            get
            { return this._cookie; }
            set
            { this._cookie = value; }
        }

        public int Count
        {
            get
            { return this._count; }
            set
            { this._count = value; }
        }
    }
    // End of readdirargs.cs
}