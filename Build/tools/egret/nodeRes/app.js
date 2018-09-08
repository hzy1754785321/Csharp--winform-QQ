var fs = require('fs');
var root_path = "resource_publish";
var w_file = 'src/core/LocalFiles.ts';
function getAllFiles(root) {
    var res = [], files = fs.readdirSync(root);
    files.forEach(function (file) {
        var pathname = root + "/"+ file
            , stat = fs.lstatSync(pathname);

        if (!stat.isDirectory()) {
            if(file != "default.res.json" && file!= "default.thm.json"){
				res.push(pathname);
			}
        } else {
            res = res.concat(getAllFiles(pathname));
        }
    });
    return res;
}
var w_content = "module game{\n\t export let LocalFileList =";
w_content += "[" + getAllFiles(root_path).map(e=>'"'+ e.replace(root_path+"/","") +'"') + "]";
w_content += ";\n}"
fs.readFile(w_file, function (err, data) {
    if (err && err.errno == 33) {
        fs.open(w_file, "w", 0666, function (e, fd) {
            if (e) throw e;
            fs.write(fd, w_content, 0, 'utf8', function (e) {
                if (e) throw e;
                fs.closeSync(fd);
            })
        });
    } else {
        fs.writeFile(w_file, w_content, function (e) {
            if (e) throw e
        })
    }
})