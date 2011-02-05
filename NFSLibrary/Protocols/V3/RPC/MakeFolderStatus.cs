/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V3.RPC
{
    public class MakeFolderAccessOK : XdrAble
    {
        private bool _handleexists;
        private NFSHandle _handle;
        private PostOperationAttributes _attributes;
        private WritingData _dir_wcc;

        public MakeFolderAccessOK()
        { }

        public MakeFolderAccessOK(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeBoolean(this._handleexists);
            if (this._handleexists)
            { this._handle.xdrEncode(xdr); }

            this._attributes.xdrEncode(xdr);
            this._dir_wcc.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._handleexists = xdr.xdrDecodeBoolean();
            if (this._handleexists)
            {
                this._handle = new NFSHandle();
                this._handle.Version = V3.RPC.NFSv3Protocol.NFS_V3;
                this._handle.xdrDecode(xdr);
            }

            this._attributes = new PostOperationAttributes(xdr);
            this._dir_wcc = new WritingData(xdr);
        }

        public bool HandleExists
        {
            get
            { return this._handleexists; }
        }

        public NFSHandle Handle
        {
            get
            { return this._handle; }
        }

        public PostOperationAttributes Attributes
        {
            get
            { return this._attributes; }
        }

        public WritingData Data
        {
            get
            { return this._dir_wcc; }
        }
    }

    public class MakeFolderAccessFAIL : XdrAble
    {
        private WritingData _dir_wcc;

        public MakeFolderAccessFAIL()
        { }

        public MakeFolderAccessFAIL(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        { this._dir_wcc.xdrEncode(xdr); }

        public void xdrDecode(XdrDecodingStream xdr)
        { this._dir_wcc = new WritingData(xdr); }

        public WritingData Data
        {
            get
            { return this._dir_wcc; }
        }
    }
    // End of MKDIR3res.cs
}