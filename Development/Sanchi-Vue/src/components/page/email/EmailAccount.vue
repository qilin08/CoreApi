<template>
  <div class="account">
    <el-form :model="form">
      <el-form-item label="邮箱账号">
        <el-col :span="6">
          <el-input
            v-model="EmailAccount"
            placeholder="请输入邮箱账号"
          ></el-input>
        </el-col>
      </el-form-item>
      <el-form-item label="用户密码">
        <el-col :span="6">
          <el-input
            v-model="PassWord"
            show-password
            placeholder="请输入密码"
          ></el-input>
        </el-col>
      </el-form-item>
      <el-form-item label="邮箱类型">
        <el-col :span="6">
          <el-input v-model="EmailType" placeholder="请输入邮箱类型"></el-input>
        </el-col>
      </el-form-item>
      <el-form-item label="收件服务器">
        <el-col :span="6">
          <el-input
            v-model="PickUpServer"
            placeholder="请输入收件服务器"
          ></el-input>
        </el-col>
      </el-form-item>
      <el-form-item label="发件服务器">
        <el-col :span="6">
          <el-input
            v-model="SendingServer"
            placeholder="请输入发件服务器"
          ></el-input>
        </el-col>
      </el-form-item>

      <el-form-item label="是否使用SSL">
        <el-col :span="6">
          <el-radio v-model="IsSSL" label="1" >是</el-radio>
          <el-radio v-model="IsSSL" label="0" >否</el-radio>
        </el-col>
      </el-form-item>

      <el-col :span="6">
        <el-button @click="fnSaveInfo" type="primary">更新</el-button>
      </el-col>
    </el-form>
  </div>
</template>

<script>
export default {
  name: "EmailAccount",
  data() {
    return {
      EmailAccount: "",
      PassWord: "",
      EmailType: "",
      PickUpServer: "",
      SendingServer: "",
      IsSSL: "1",
      form: {},
    };
  },
  //在这里调用ajax请求方法
  created() {
    this.fnGetInfo();
  },

  methods: {
    fnGetInfo: function () {
      //GET
      this.axios.get("api/Email/GetEmailInfo")
        .then((response) => {
          var _data = response.data.data;
          // console.log(_data);
          this.EmailAccount = _data.emailAccount;
          this.PassWord = _data.passWord;
          this.EmailType = _data.emailType;
          this.PickUpServer = _data.pickUpServer;
          this.SendingServer = _data.sendingServer;
          this.IsSSL = _data.isSSL ? "1" : "0";
        })
        .catch(function (err) {
          console.log(err);
        });
    },

//     Vue.axios.get(api).then((response) => {
//   console.log(response.data)
// })

    fnSaveInfo: function () {
      //Post
      this.$ajax({
        method: "post",
        url: "api/Email/SetEmailInfo",
        data: {
          EmailAccount: this.EmailAccount,
          PassWord: this.PassWord,
          EmailType: this.EmailType,
          PickUpServer: this.PickUpServer,
          SendingServer: this.SendingServer,
          IsSSL: this.IsSSL === "1" ? true : false,
        },
      })
        .then(function (response) {
          console.log(response);
        })
        .catch(function (err) {
          console.log(err);
        });

      this.fnGetInfo();
    },
  },
};
</script>

<style scoped>

</style>
