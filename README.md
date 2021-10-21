该工程是入职海纳医信学习内镜心电代码时写的Demo 四则运算计算器
涉及的知识点有 MVP模式(Model、View、Presenter)、多语言化、Mapper、EF、Ioc
MVP模式的核心思想是 将UI里的逻辑代码放到Presenter层里 将业务逻辑层的代码放在Model层 
View里一般包括一个UI接口和接口实现类(如代码里的ICalculatorFormable和CalculatorForm),界面只用于展示，而提供数据和得到数据展示到控件中这类的行为和涉及的数据（属性）需要定义在接口中，
Presenter依赖View里的接口，依赖Model
UI继承View里的接口，依赖Presenetr.

目前已实现MVP模式的逻辑结构分层和多语言化 2021.10.19


常用git操作命令

git inint   											# 在当前目录创建git仓库
git add .												# 添加文件到暂存区(增加文件或修改文件后需要调用)
git commit -m "提交日志信息" 							# 将暂存区内容添加到本地仓库中

git remote -v  											# 列举出所有远程仓库
git remote show [远程地址别名] 							# 显示某个远程仓库的信息
git remote add  [远程地址别名]  [远程地址]				# 添加远程版本库
git push -u [远程地址别名] [分支名称]
git remote rm [远程地址别名]  							# 删除远程仓库
git remote rename [远程地址别名] new_name  				# 修改仓库名
git push <远程地址别名> <本地分支名>:<远程分支名>		# 用于从将本地的分支版本上传到远程并合并。 

如果本地分支名与远程分支名相同，则可以省略冒号：
git push <远程地址别名> <本地分支名>

如果本地版本与远程版本有差异，但又要强制推送可以使用 --force 参数：
git push --force origin master