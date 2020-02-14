import React, { Component } from 'react';

export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
        this.state = { username: '', password: '' , status: 'Not Logged in'};

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit(event) {
        debugger;
        if (this.state.username === "John" && this.state.password === "Doe")
            this.setState({ status: event.target.status });
        event.preventDefault();
        
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                    Username :
          <input id="username" type="text" value={this.state.username}  />
                </label>
                <br />
                <label>
                    Password :
          <input id="password" type="password" value={this.state.password} />
                </label>
                <br/>
                <input type="submit" value="Envoyer" />
                <h1 id="status">{this.state.status}</h1>
            </form>
            
            
        );
    }
}