# Ac682.Hyperai.Clients.CQHTTP

实际对标的是 go-cqhttp 而不是 cqhttp.
~~可惜的是这两者都没有api文档可以参考(前者说看后者,后者倒了,onebot接口和实际的go-http返回值不一致),现在就是摸着石头过河,全靠一个一个试验出来.~~
[旧文档](https://richardchien.gitee.io/coolq-http-api/docs/4.15)找到了

## 部署

同隔壁 [Mirai Adapter](https://github.com/ac682/Ac682.Hyperai.Clients.Mirai), `Options` 只需要填 `Host`, `HttpPort`, `WebSocketPort`, `AccessToken` 就行。

**依赖 Wupoo 包**

从 nuget 上下载一个然后丢尽 `plugins` 文件夹就行了

## 实现与未实现

- [x] 大部分
- [x] MessageId 获取, ~~因为是异步的, 所以没法在函数返回前提供 MessageId~~换成同步http发送了
- [x] 小部分


### 接收事件

- [x] 私聊消息
- [x] 群聊消息
- [x] 群消息撤回
- [x] 私聊消息撤回
- [x] 自己/群员被踢/离开
- [x] 群员被禁言
- [x] 群员改名片
- [x] 群成员加入
- [ ] 其他一概未知(未测出来

### 发送事件

- [x] 私聊消息
- [x] 群聊消息
- [x] 私聊消息撤回
- [x] 群聊消息撤回
- [x] 退群/踢人
- [x] 禁言/解禁
- [x] 全员禁言
- [x] 设置群名片
- [x] 设置群名
- [ ] 其他所有

## 消息元素

- [x] Plain
- [x] Image
- [x] Face
- [x] Flash
- [x] At
- [x] AtAll
- [x] Quote 只收不发，官方文档对`reply`的描述有出入，但不管那种，都不work
- [x] ~~Source, 没有MessageId, 也意味着无法回复了~~现在有了
- [ ] 所有 ContentBase 派生
- [x] 有什么不懂就塞给 Unknown