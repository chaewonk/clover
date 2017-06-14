S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.1
Build-Number: R760XXU1APL2
Build-Date: 2016.12.20 22:57:01

Crash Information
Process Name: clover
PID: 9771
Date: 2017-05-25 17:04:35+0900
Executable File Path: /opt/usr/apps/org.example.clover/bin/clover
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9771, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xf5bca26c, r3   = 0x00000001
r4   = 0xf6f929b8, r5   = 0xf6f929b8
r6   = 0xf6f9216c, r7   = 0xffd20dc0
r8   = 0xf6f929b8, r9   = 0xf79a7b80
r10  = 0xf6fa0b10, fp   = 0x00000000
ip   = 0xf5bca2ac, sp   = 0xffd20d78
lr   = 0xf6d565d0, pc   = 0xf5bb6562
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      5180 KB
Buffers:     40468 KB
Cached:     173668 KB
VmPeak:     189992 KB
VmSize:     189988 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37108 KB
VmRSS:       37104 KB
VmData:     111948 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29384 KB
VmPTE:         192 KB
VmSwap:          0 KB

Threads Information
Threads: 11
PID = 9771 TID = 9771
9771 9851 9852 9860 9861 9862 9863 9864 9865 9866 9867 

Maps Information
ecefe000 ed6fd000 rw-p [stack:9867]
ed6fe000 ee2fe000 rw-p [stack:9866]
ee2ff000 eeafe000 rw-p [stack:9865]
eeaff000 ef2fe000 rw-p [stack:9864]
efc8b000 f048a000 rw-p [stack:9863]
f048b000 f0c8a000 rw-p [stack:9862]
f0c8a000 f0c8d000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
f0c95000 f0caf000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
f0cb8000 f0cf0000 r-xp /usr/lib/libsamrnb.so
f0d13000 f0d1e000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
f0d27000 f0d37000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
f0d3f000 f0d45000 r-xp /usr/lib/libscmn.so
f0d4d000 f0d85000 r-xp /usr/lib/libsaac.so
f0d8f000 f0d94000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
f0d9c000 f0dac000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
f0dcd000 f0dd5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
f0de4000 f0de9000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
f0dfb000 f0e13000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
f0e23000 f0e29000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
f0e31000 f0e49000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f0e52000 f0e7b000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f0e8d000 f0e92000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
f0e9a000 f0ff8000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
f10e0000 f10ec000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
f10f4000 f1128000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
f11b1000 f19b0000 rw-p [stack:9852]
f19b1000 f21b0000 rw-p [stack:9851]
f2258000 f2a57000 rw-p [stack:9860]
f2c04000 f2c24000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
f2c25000 f2c30000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f2c38000 f2c3a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f2c42000 f2c43000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f2c4b000 f2c53000 r-xp /usr/lib/libfeedback.so.0.1.4
f2c58000 f2c5b000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
f2c63000 f2c64000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
f2c6c000 f2c6d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f2c75000 f2c76000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f2d10000 f350f000 rw-p [stack:9861]
f350f000 f3511000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f3519000 f3530000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f353d000 f3542000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f354a000 f3555000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f388f000 f3981000 r-xp /usr/lib/libCOREGL.so.4.0
f399a000 f399f000 r-xp /usr/lib/libsystem.so.0.0.0
f39a9000 f39aa000 r-xp /usr/lib/libresponse.so.0.2.96
f39b2000 f39b7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f39c0000 f39c2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f39ca000 f39d1000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f39da000 f39fc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3a05000 f3a09000 r-xp /usr/lib/libogg.so.0.7.1
f3a11000 f3a33000 r-xp /usr/lib/libvorbis.so.0.4.3
f3a3b000 f3a3e000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3a46000 f3a55000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3a5e000 f3a66000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3a6e000 f3a74000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3a7d000 f3a84000 r-xp /usr/lib/libminizip.so.1.0.0
f3a8c000 f3a8e000 r-xp /usr/lib/libttrace.so.1.1
f3a96000 f3add000 r-xp /usr/lib/libsndfile.so.1.0.26
f3ae9000 f3b32000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3b3b000 f3b40000 r-xp /usr/lib/libjson.so.0.0.1
f53d9000 f54df000 r-xp /usr/lib/libicuuc.so.57.1
f54f5000 f567d000 r-xp /usr/lib/libicui18n.so.57.1
f568d000 f569a000 r-xp /usr/lib/libail.so.0.1.0
f56a3000 f56a6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f56ae000 f56b1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f56b9000 f571a000 r-xp /usr/lib/libasound.so.2.0.0
f5724000 f573a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5742000 f5746000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f574e000 f578f000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f5798000 f579a000 r-xp /usr/lib/libdri2.so.0.0.0
f57a2000 f57aa000 r-xp /usr/lib/libdrm.so.2.4.0
f57b2000 f57b8000 r-xp /usr/lib/libxcb-render.so.0.0.0
f57c0000 f57c1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f57ca000 f57ce000 r-xp /usr/lib/libEGL.so.1.4
f57de000 f57ef000 r-xp /usr/lib/libGLESv2.so.2.0
f57ff000 f5847000 r-xp /usr/lib/libmdm.so.1.2.62
f5848000 f584f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5857000 f5862000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f586f000 f5888000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f5890000 f5895000 r-xp /usr/lib/libstorage.so.0.1
f589d000 f58a2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f58aa000 f58e2000 r-xp /usr/lib/libpulse.so.0.16.2
f58e3000 f58e7000 r-xp /usr/lib/libmmfsession.so.0.0.0
f58f0000 f5907000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5919000 f593a000 r-xp /usr/lib/libexif.so.12.3.3
f594d000 f5956000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f595e000 f596b000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5974000 f597f000 r-xp /usr/lib/libtbm.so.1.0.0
f5987000 f598c000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5994000 f5a4c000 r-xp /usr/lib/libcairo.so.2.11200.14
f5a57000 f5af2000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5afe000 f5b4e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f5b54000 f5b66000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f5b6e000 f5b8f000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5b97000 f5b9c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5ba4000 f5bac000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.28
f5bb4000 f5bbb000 r-xp /opt/usr/apps/org.example.clover/bin/clover
f5d5d000 f5d67000 r-xp /lib/libnss_files-2.13.so
f5d70000 f5e3f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5e55000 f5e79000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5e82000 f5e88000 r-xp /usr/lib/libappsvc.so.0.1.0
f5e90000 f5e92000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5e9b000 f5e9f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5eab000 f5eb6000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5ebe000 f5ec0000 r-xp /usr/lib/libiniparser.so.0
f5ec9000 f5ece000 r-xp /usr/lib/libappcore-common.so.1.1
f5ed6000 f5ed8000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f5ee0000 f5ee4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5ef1000 f5ef3000 r-xp /usr/lib/libXau.so.6.0.0
f5efb000 f5f02000 r-xp /lib/libcrypt-2.13.so
f5f32000 f5f34000 r-xp /usr/lib/libiri.so
f5f3d000 f60e6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6106000 f614d000 r-xp /usr/lib/libssl.so.1.0.0
f6159000 f6187000 r-xp /usr/lib/libidn.so.11.5.44
f618f000 f6198000 r-xp /usr/lib/libcares.so.2.1.0
f61a2000 f61b5000 r-xp /usr/lib/libxcb.so.1.1.0
f61be000 f61c0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f61c8000 f61ca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f61d3000 f629f000 r-xp /usr/lib/libxml2.so.2.7.8
f62ac000 f62ae000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f62b7000 f62bc000 r-xp /usr/lib/libffi.so.5.0.10
f62c4000 f62c5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f62cd000 f62d0000 r-xp /lib/libattr.so.1.1.0
f62d8000 f636c000 r-xp /usr/lib/libstdc++.so.6.0.16
f637f000 f639c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f63a6000 f63be000 r-xp /usr/lib/libpng12.so.0.50.0
f63c6000 f63dc000 r-xp /lib/libexpat.so.1.6.0
f63e6000 f642a000 r-xp /usr/lib/libcurl.so.4.3.0
f6433000 f643d000 r-xp /usr/lib/libXext.so.6.4.0
f6446000 f644a000 r-xp /usr/lib/libXtst.so.6.1.0
f6452000 f6458000 r-xp /usr/lib/libXrender.so.1.3.0
f6460000 f6466000 r-xp /usr/lib/libXrandr.so.2.2.0
f646e000 f646f000 r-xp /usr/lib/libXinerama.so.1.0.0
f6478000 f6481000 r-xp /usr/lib/libXi.so.6.1.0
f6489000 f648c000 r-xp /usr/lib/libXfixes.so.3.1.0
f6494000 f6496000 r-xp /usr/lib/libXgesture.so.7.0.0
f649e000 f64a0000 r-xp /usr/lib/libXcomposite.so.1.0.0
f64a8000 f64aa000 r-xp /usr/lib/libXdamage.so.1.1.0
f64b2000 f64b9000 r-xp /usr/lib/libXcursor.so.1.0.2
f64c1000 f64c4000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f64cc000 f64d0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f64d9000 f64de000 r-xp /usr/lib/libecore_fb.so.1.7.99
f64e7000 f65c8000 r-xp /usr/lib/libX11.so.6.3.0
f65d3000 f65f6000 r-xp /usr/lib/libjpeg.so.8.0.2
f660e000 f6624000 r-xp /lib/libz.so.1.2.5
f662c000 f662e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6636000 f66ab000 r-xp /usr/lib/libsqlite3.so.0.8.6
f66b5000 f66cf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66d7000 f670b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6714000 f67e7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67f2000 f6802000 r-xp /lib/libresolv-2.13.so
f6806000 f681e000 r-xp /usr/lib/liblzma.so.5.0.3
f6826000 f6829000 r-xp /lib/libcap.so.2.21
f6831000 f6860000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6868000 f6869000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6871000 f6877000 r-xp /usr/lib/libecore_imf.so.1.7.99
f687f000 f6896000 r-xp /usr/lib/liblua-5.1.so
f689f000 f68a6000 r-xp /usr/lib/libembryo.so.1.7.99
f68ae000 f68b4000 r-xp /lib/librt-2.13.so
f68bd000 f6913000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6920000 f6976000 r-xp /usr/lib/libfreetype.so.6.11.3
f6982000 f69aa000 r-xp /usr/lib/libfontconfig.so.1.8.0
f69ab000 f69f0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f69f9000 f6a0c000 r-xp /usr/lib/libfribidi.so.0.3.1
f6a14000 f6a2e000 r-xp /usr/lib/libecore_con.so.1.7.99
f6a37000 f6a40000 r-xp /usr/lib/libedbus.so.1.7.99
f6a48000 f6a98000 r-xp /usr/lib/libecore_x.so.1.7.99
f6a9a000 f6aa3000 r-xp /usr/lib/libvconf.so.0.2.45
f6aab000 f6abc000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ac4000 f6ac9000 r-xp /usr/lib/libecore_file.so.1.7.99
f6ad1000 f6af3000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6afc000 f6b3d000 r-xp /usr/lib/libeina.so.1.7.99
f6b46000 f6b5f000 r-xp /usr/lib/libeet.so.1.7.99
f6b70000 f6bd9000 r-xp /lib/libm-2.13.so
f6be2000 f6be8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bf1000 f6bf2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bfa000 f6c1d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c25000 f6c2a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c32000 f6c5c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c65000 f6c7c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c84000 f6c8f000 r-xp /lib/libunwind.so.8.0.1
f6cbc000 f6cda000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ce4000 f6e08000 r-xp /lib/libc-2.13.so
f6e16000 f6e1e000 r-xp /lib/libgcc_s-4.6.so.1
f6e1f000 f6e23000 r-xp /usr/lib/libsmack.so.1.0.0
f6e2c000 f6e32000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6e3a000 f6f0a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f0b000 f6f69000 r-xp /usr/lib/libedje.so.1.7.99
f6f73000 f6f8a000 r-xp /usr/lib/libecore.so.1.7.99
f6fa1000 f706f000 r-xp /usr/lib/libevas.so.1.7.99
f7094000 f71d0000 r-xp /usr/lib/libelementary.so.1.7.99
f71e7000 f71fb000 r-xp /lib/libpthread-2.13.so
f7206000 f7208000 r-xp /usr/lib/libdlog.so.0.0.0
f7210000 f7213000 r-xp /usr/lib/libbundle.so.0.1.22
f721b000 f721d000 r-xp /lib/libdl-2.13.so
f7226000 f7233000 r-xp /usr/lib/libaul.so.0.1.0
f7244000 f724a000 r-xp /usr/lib/libappcore-efl.so.1.1
f7253000 f7257000 r-xp /usr/lib/libsys-assert.so
f7260000 f727d000 r-xp /lib/ld-2.13.so
f7286000 f728b000 r-xp /usr/bin/launchpad-loader
f796f000 f7aff000 rw-p [heap]
ffd01000 ffd22000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9771)
Call Stack Count: 12
 0: ecore_timer_cb + 0xc9 (0xf5bb6562) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2562
 1: (0xf6f821f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0xf6f822ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0xf6f7f2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0xf6f7f879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0xf7247b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0xf5ee2421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: uib_app_run + 0xea (0xf5bb6ef3) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2ef3
 8: main + 0x34 (0xf5bb6489) [/opt/usr/apps/org.example.clover/bin/clover] + 0x2489
 9: (0xf7287a53) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1a53
10: __libc_start_main + 0x114 (0xf6cfb85c) [/lib/libc.so.6] + 0x1785c
11: (0xf7287e0c) [/opt/usr/apps/org.example.clover/bin/clover] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.clover
Package ID : org.example.clover
Version: 1.0.0
Package Type: rpm
App Name: clover
App ID: org.example.clover
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
05-25 17:04:00.351+0900 E/AUL     ( 9773): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:04:00.351+0900 I/AUL     ( 9773): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:00.361+0900 I/AUL     ( 9773): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:00.361+0900 E/AUL     ( 9773): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:04:00.361+0900 E/AUL     ( 9773): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:04:00.381+0900 I/AUL     ( 9773): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:00.381+0900 I/AUL     ( 9773): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:00.381+0900 E/AUL     ( 9773): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:04:00.391+0900 E/AUL     ( 9773): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:04:00.391+0900 I/AUL     ( 9773): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:00.401+0900 I/AUL     ( 9773): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:00.411+0900 E/AUL     ( 9773): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:04:00.411+0900 E/AUL     ( 9773): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:04:00.431+0900 I/UXT     ( 9773): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-25 17:04:00.571+0900 E/MALI    ( 9773): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:04:00.571+0900 W/CoreGL  ( 9773): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
05-25 17:04:00.661+0900 E/PKGMGR_SERVER( 9760): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
05-25 17:04:01.421+0900 E/rpm-installer( 9761): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-25 17:04:01.421+0900 E/rpm-installer( 9761): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-25 17:04:01.421+0900 E/rpm-installer( 9761): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-25 17:04:01.431+0900 E/PKGMGR_SERVER( 9760): pkgmgr-server.c: sighandler(486) > child NORMAL exit [9761]
05-25 17:04:01.461+0900 E/RESOURCED( 2613): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/9761/oom_score_adj failed
05-25 17:04:01.461+0900 E/RESOURCED( 2613): proc-main.c: resourced_proc_status_change(1504) > Empty pid or process not exists. 9761
05-25 17:04:01.631+0900 I/AUL     ( 9783): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-25 17:04:01.641+0900 I/AUL     ( 9783): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-25 17:04:01.641+0900 E/AUL     ( 9783): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-25 17:04:01.641+0900 E/AUL     ( 9783): aul_path.c: __get_path(169) > root_path is NULL!
05-25 17:04:02.661+0900 E/PKGMGR_SERVER( 9760): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
05-25 17:04:02.661+0900 E/PKGMGR_SERVER( 9760): pkgmgr-server.c: main(2281) > package manager server terminated.
05-25 17:04:02.921+0900 W/AUL     ( 9848): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.clover)
05-25 17:04:02.921+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 0
05-25 17:04:02.951+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-25 17:04:02.961+0900 I/AUL_AMD ( 2490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-25 17:04:02.961+0900 E/AUL_AMD ( 2490): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-25 17:04:02.961+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(1782) > caller pid : 9848
05-25 17:04:02.981+0900 E/RESOURCED( 2613): block.c: block_prelaunch_state(138) > insert data org.example.clover, table num : 3
05-25 17:04:02.991+0900 W/AUL_AMD ( 2490): amd_launch.c: _start_app(2218) > pad pid(-5)
05-25 17:04:02.991+0900 W/AUL_PAD ( 3264): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-25 17:04:02.991+0900 W/AUL_PAD ( 3264): launchpad.c: __send_result_to_caller(272) > Check app launching
05-25 17:04:02.991+0900 W/AUL_PAD ( 9771): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-25 17:04:02.991+0900 W/AUL_PAD ( 9771): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-25 17:04:02.991+0900 W/AUL_PAD ( 9771): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-25 17:04:02.991+0900 W/AUL_PAD ( 9771): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.clover)
05-25 17:04:03.051+0900 I/efl-extension( 9771): efl_extension.c: eext_mod_init(40) > Init
05-25 17:04:03.051+0900 W/AUL_PAD ( 9771): launchpad_loader.c: main(690) > [candidate] dlsym
05-25 17:04:03.051+0900 W/AUL_PAD ( 9771): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.clover)
05-25 17:04:03.051+0900 I/CAPI_APPFW_APPLICATION( 9771): app_main.c: ui_app_main(704) > app_efl_main
05-25 17:04:03.061+0900 I/CAPI_APPFW_APPLICATION( 9771): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-25 17:04:03.091+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.clover) pid(9771) type(uiapp) bg(0)
05-25 17:04:03.091+0900 W/AUL_AMD ( 2490): amd_status.c: __socket_monitor_cb(1277) > (9771) was created
05-25 17:04:03.091+0900 W/AUL     ( 9848): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9771)
05-25 17:04:03.101+0900 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [9771]
05-25 17:04:03.151+0900 E/EFL     ( 9771): ecore_evas<9771> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-25 17:04:03.161+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
05-25 17:04:03.161+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:03.161+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:03.161+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:04:03.171+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:03.171+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
05-25 17:04:03.171+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:04:03.211+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:04:03.221+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2b21088) will be pushed
05-25 17:04:03.261+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:03.261+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:03.261+0900 I/APP_CORE( 9771): appcore-efl.c: __do_app(453) > [APP 9771] Event: RESET State: CREATED
05-25 17:04:03.261+0900 I/CAPI_APPFW_APPLICATION( 9771): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-25 17:04:03.271+0900 I/APP_CORE( 9771): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-25 17:04:03.271+0900 I/APP_CORE( 9771): appcore-efl.c: __do_app(524) > [APP 9771] Initial Launching, call the resume_cb
05-25 17:04:03.271+0900 I/CAPI_APPFW_APPLICATION( 9771): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-25 17:04:03.271+0900 W/APP_CORE( 9771): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-25 17:04:03.331+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(1)
05-25 17:04:03.331+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
05-25 17:04:03.331+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:03.331+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:03.331+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
05-25 17:04:03.331+0900 I/APP_CORE( 9771): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
05-25 17:04:03.331+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: PAUSE State: RUNNING
05-25 17:04:03.331+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-25 17:04:03.331+0900 W/W_HOME  ( 2724): main.c: _appcore_pause_cb(488) > appcore pause
05-25 17:04:03.331+0900 E/W_HOME  ( 2724): main.c: _pause_cb(466) > paused already
05-25 17:04:03.331+0900 I/APP_CORE( 2724): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
05-25 17:04:03.331+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-25 17:04:03.331+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:04:03.331+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [3], notiboard card appending count [8].
05-25 17:04:03.341+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(bg) type(uiapp)
05-25 17:04:03.341+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:04:03.341+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:04:03.341+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.clover) pid(9771) status(fg) type(uiapp)
05-25 17:04:03.341+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (4)
05-25 17:04:03.341+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(4)
05-25 17:04:03.341+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[9771] goes to (3)
05-25 17:04:03.731+0900 E/AUL     ( 2490): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-25 17:04:04.191+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:04:04.201+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9771
05-25 17:04:04.201+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:04:04.221+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 14
05-25 17:04:04.231+0900 W/AUL_AMD ( 2490): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9771
05-25 17:04:04.231+0900 W/AUL_AMD ( 2490): amd_request.c: __request_handler(669) > __request_handler: 12
05-25 17:04:04.421+0900 I/AUL_PAD ( 9853): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-25 17:04:08.341+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: MEM_FLUSH State: PAUSED
05-25 17:04:28.551+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-25 17:04:28.551+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-25 17:04:28.551+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:04:28.551+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-25 17:04:28.551+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:04:28.561+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [3913.903262] dpms[3 -> 0]sync[0]
05-25 17:04:28.561+0900 I/TDM     ( 1552): 
05-25 17:04:28.561+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3913.903456] dpms[0 -> 0]done
05-25 17:04:28.561+0900 I/TDM     ( 1552): 
05-25 17:04:28.581+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -145485408[0;m
05-25 17:04:28.611+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:04:28.611+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:04:28.611+0900 W/W_HOME  ( 2724): gesture.c: _widget_updated_cb(188) > widget updated
05-25 17:04:28.611+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:04:28.611+0900 W/W_HOME  ( 2724): gesture.c: _manual_render(182) > 
05-25 17:04:28.611+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:04:28.611+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:04:28.621+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-25 17:04:28.621+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-25 17:04:28.631+0900 I/APP_CORE( 9771): appcore-efl.c: __do_app(453) > [APP 9771] Event: RESUME State: RUNNING
05-25 17:04:28.631+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [125136]ms
05-25 17:04:28.631+0900 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:04:28.631+0900 W/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-25 17:04:28.631+0900 I/wnotibp ( 3231): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-25 17:04:28.631+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:04:28.631+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-25 17:04:28.641+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3913.981302] layer(0x874fb8) not usable
05-25 17:04:28.641+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3913.981366] layer(0x874fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:04:28.641+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3913.981392] layer[0x874b08]zpos[1]
05-25 17:04:28.641+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1442) > [3913.981481] layer(0x875008) not usable
05-25 17:04:28.641+0900 I/TDM     ( 1552): tdm_display.c: tdm_layer_set_info(1459) > [3913.981500] layer(0x875008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-25 17:04:28.641+0900 I/TDM     ( 1552): tdm_exynos_display.c: exynos_layer_set_info(1578) > [3913.981522] layer[0x874c28]zpos[2]
05-25 17:04:28.641+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-25 17:04:28.641+0900 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
05-25 17:04:28.651+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:04:28.651+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:04:28.651+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:04:28.651+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:04:28.661+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:04:28.661+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:04:28.661+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:04:28.661+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:04:28.661+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147223796[0;m
05-25 17:04:28.661+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-25 17:04:28.661+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-25 17:04:28.661+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-25 17:04:28.661+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-25 17:04:28.661+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-25 17:04:28.661+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-25 17:04:28.671+0900 E/WAKEUP-SERVICE( 3216): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-25 17:04:28.671+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-25 17:04:28.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-25 17:04:28.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-25 17:04:28.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3233): preference.c: preference_get_boolean(1173) > preference_get_boolean(3233) : test_healthy_pace error
05-25 17:04:28.681+0900 I/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-25 17:04:28.691+0900 W/TIZEN_N_SOUND_MANAGER( 3216): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-25 17:04:28.691+0900 W/WAKEUP-SERVICE( 3216): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-25 17:04:28.691+0900 I/HIGEAR  ( 3216): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-25 17:04:28.701+0900 W/W_HOME  ( 2724): gesture.c: _manual_render(182) > 
05-25 17:04:28.711+0900 W/SHealthCommon( 3233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1495670400000.000000[0;m
05-25 17:04:28.731+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (916859)]][0;m
05-25 17:04:28.761+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): gesture.c: _apps_status_get(128) > apps status:0
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:0 info->offtime:125136
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-25 17:04:28.771+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:28.791+0900 W/SHealthCommon( 3233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-25 17:04:28.791+0900 W/SHealthWidget( 2843): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (916859), msgName: timeline_summary_updated[0;m
05-25 17:04:28.791+0900 W/SHealthCommon( 2843): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-25 17:04:28.791+0900 W/SHealthWidget( 2843): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-25 17:04:28.791+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1495731868806.000000, pattern:[HH:mm][0;m
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:04:28.791+0900 E/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
05-25 17:04:28.791+0900 W/WSLib   ( 2843): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:04][0;m
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-25 17:04:28.791+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-25 17:04:28.791+0900 I/CAPI_WIDGET_APPLICATION( 2843): widget_app.c: __provider_update_cb(281) > received updating signal
05-25 17:04:28.841+0900 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
05-25 17:04:28.841+0900 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
05-25 17:04:28.881+0900 W/SHealthService( 3233): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
05-25 17:04:28.881+0900 W/SHealthCommon( 2843): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:04:28.881+0900 I/HealthDataService( 2909): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-25 17:04:28.901+0900 I/healthData( 3233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-25 17:04:28.901+0900 W/SHealthCommon( 3233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-25 17:04:28.901+0900 W/SHealthService( 3233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-25 17:04:28.971+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-25 17:04:28.971+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_enable(138) > 0
05-25 17:04:28.971+0900 W/W_HOME  ( 2724): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-25 17:04:30.171+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-25 17:04:30.171+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-25 17:04:30.171+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:04:30.171+0900 W/WECONN  ( 2478): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
05-25 17:04:30.171+0900 W/WECONN  ( 2478): <__wc_device_on_wear_onoff_changed_cb:353> { state=WC_FEATURE_STATE_OFF
05-25 17:04:30.171+0900 W/WECONN  ( 2478): <__wc_device_on_wear_onoff_changed_cb:384> }
05-25 17:04:30.171+0900 W/WECONN  ( 2478): <__wc_feature_wearonoff_monitor_cb:531> }
05-25 17:04:30.171+0900 E/wnoti-service( 2946): wnoti-db-utility.c: context_wearonoff_status_cb(2092) > status changed from 1 to 2 
05-25 17:04:30.181+0900 E/WMS     ( 2450): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23450) > wear_monitor_status update[0] = 1 -> 2
05-25 17:04:30.181+0900 E/WMS     ( 2450): wms_msg_broker.c: wms_msg_broker_send(1825) > 
05-25 17:04:30.181+0900 E/WMS     ( 2450): ==========
05-25 17:04:30.181+0900 E/WMS     ( 2450): ##WMS SEND : mgr_gear_wear_onoff_req
05-25 17:04:30.181+0900 E/WMS     ( 2450): ==========
05-25 17:04:30.181+0900 E/WMS     ( 2450): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 52 MAX Buffer Size: 61440
05-25 17:04:30.211+0900 E/WMS     ( 2450): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
05-25 17:04:30.211+0900 W/SCSD    ( 2967): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-25 17:04:30.211+0900 W/SCSD    ( 2967): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-25 17:04:30.211+0900 W/SCSD    ( 2967): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-25 17:04:30.211+0900 W/SCSD    ( 2967): <util_scs_send:976> sent [63 / 63] bytes. 
05-25 17:04:30.241+0900 W/SHealthService( 3233): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
05-25 17:04:32.791+0900 E/EFL     ( 9771): ecore_x<9771> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3918136 button=1
05-25 17:04:32.841+0900 E/EFL     ( 9771): ecore_x<9771> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3918185 button=1
05-25 17:04:32.921+0900 I/USR_TAG ( 9771): record_start
05-25 17:04:32.921+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [recorder_attr_set_time_limit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:32.921+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:32.921+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:32.921+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:33.221+0900 E/TIZEN_N_RECORDER( 9771): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-25 17:04:33.221+0900 E/EFL     ( 9771): <9771> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:04:33.221+0900 E/EFL     ( 9771): <9771> elm_main.c:1300 elm_object_disabled_set() safety check failed: obj == NULL
05-25 17:04:33.231+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-25 17:04:33.241+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:2950 elm_naviframe_item_push() item(0xf2b9e608) will be pushed
05-25 17:04:33.251+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:2796 _push_transition_cb() item(0xf2b9e608) will transition
05-25 17:04:33.671+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:1193 _on_item_push_finished() item(0xf2b21088) transition finished
05-25 17:04:33.671+0900 E/EFL     ( 9771): elementary<9771> elc_naviframe.c:1218 _on_item_show_finished() item(0xf2b9e608) transition finished
05-25 17:04:33.851+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=3918589
05-25 17:04:33.851+0900 E/EFL     ( 9771): ecore_x<9771> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=3918589
05-25 17:04:33.851+0900 E/EFL     ( 2318): ecore_x<2318> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=3918589
05-25 17:04:35.821+0900 I/USR_TAG ( 9771): loud sound is detected!
05-25 17:04:36.141+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9771 pgid = 9771
05-25 17:04:36.141+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-25 17:04:36.191+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:04:36.191+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:04:36.191+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:04:36.191+0900 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
05-25 17:04:36.191+0900 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
05-25 17:04:36.191+0900 W/AUL_AMD ( 2490): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-25 17:04:36.191+0900 W/AUL_AMD ( 2490): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-25 17:04:36.191+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
05-25 17:04:36.231+0900 W/PROCESSMGR( 2318): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-25 17:04:36.241+0900 W/AUL_PAD ( 3264): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-25 17:04:36.241+0900 W/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-25 17:04:36.241+0900 I/WATCH_CORE( 2779): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-25 17:04:36.241+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:04:36.251+0900 I/AUL_AMD ( 2490): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9771
05-25 17:04:36.251+0900 W/AUL     ( 2490): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9771)
05-25 17:04:36.271+0900 W/W_HOME  ( 2724): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-25 17:04:36.271+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.271+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.281+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.281+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-25 17:04:36.281+0900 W/W_HOME  ( 2724): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(473) > Window [0x1E00003] is now visible(0)
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
05-25 17:04:36.291+0900 I/APP_CORE( 2724): appcore-efl.c: __do_app(453) > [APP 2724] Event: RESUME State: PAUSED
05-25 17:04:36.291+0900 I/CAPI_APPFW_APPLICATION( 2724): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): main.c: _appcore_resume_cb(479) > appcore resume
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): main.c: home_resume(531) > clock/widget resumed
05-25 17:04:36.291+0900 W/W_HOME  ( 2724): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-25 17:04:36.311+0900 I/wnotib  ( 2724): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-25 17:04:36.311+0900 E/wnotib  ( 2724): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-25 17:04:36.311+0900 W/wnotib  ( 2724): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-25 17:04:36.321+0900 W/WATCH_CORE( 2779): appcore-watch.c: __widget_resume(1124) > widget_resume
05-25 17:04:36.321+0900 W/AUL     ( 2779): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(2779) status(fg) type(watchapp)
05-25 17:04:36.321+0900 D/chronograph( 2779): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
05-25 17:04:36.321+0900 D/chronograph( 2779): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
05-25 17:04:36.321+0900 W/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
05-25 17:04:36.321+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 36, msec = 334
05-25 17:04:36.321+0900 D/chronograph( 2779): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
05-25 17:04:36.321+0900 D/chronograph-common( 2779): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
05-25 17:04:36.321+0900 D/chronograph-common( 2779): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
05-25 17:04:36.331+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-25 17:04:36.341+0900 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
05-25 17:04:36.341+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
05-25 17:04:36.341+0900 W/W_INDICATOR( 2651): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
05-25 17:04:36.341+0900 I/CAPI_WATCH_APPLICATION( 2779): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-25 17:04:36.341+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(30), length(2)
05-25 17:04:36.351+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 30%
05-25 17:04:36.351+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 30, isCharging: 0
05-25 17:04:36.351+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
05-25 17:04:36.351+0900 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
05-25 17:04:36.391+0900 W/CRASH_MANAGER( 9874): worker.c: worker_job(1199) > 1109771636c6f149569947
