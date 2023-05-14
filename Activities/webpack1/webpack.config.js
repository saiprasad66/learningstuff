const path=require('path')

module.exports={
    mode:'development',
    entry:{
        main:path.resolve(__dirname,'./src/app/index.js')
    },
    module:
    {
        rules:[

            {
                test: /\.ts$/,
                use:'ts-loader',
            }
        ]
    },
    
    output:
    {
        path:path.resolve(__dirname,'./dist'),
        filename:'[name].bundle.js',
    }
}