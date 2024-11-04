import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { Row, Col, Button, Form, FormGroup, Label, Input } from 'reactstrap';

const AuthPage = () => {
  const [isLogin, setIsLogin] = useState(true);

  const switchModeHandler = () => {
    setIsLogin(prevIsLogin => !prevIsLogin);
  };

  const submitHandler = event => {
    event.preventDefault();
    const email = event.currentTarget.elements.email.value;
    const password = event.currentTarget.elements.password.value;

    if (isLogin) {
      fetch('/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ email, password })
      })
        .then(res => {
          if (res.ok) {
            return res.json();
          }
          return res.json().then(data => {
            throw new Error(data.message);
          });
        })
        .then(data => console.log(data))
        .catch(err => console.error(err));
    } else {
      fetch('/signup', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ email, password, confirmPassword: password })
      })
        .then(res => {
          if (res.ok) {
            return res.json();
          }
          return res.json().then(data => {
            throw new Error(data.message);
          });
        })
        .then(data => console.log(data))
        .catch(err => console.error(err));
    }
  };

  return (
    <Row>
      <Col sm={{ size: 6, offset: 3 }}>
        <h1>{isLogin ? 'Login' : 'Sign up'}</h1>
        <Form onSubmit={submitHandler}>
          <FormGroup>
            <Label for="email">Email</Label>
            <Input type="email" name="email" id="email" placeholder="Email" />
          </FormGroup>
          <FormGroup>
            <Label for="password">Password</Label>
            <Input type="password" name="password" id="password" placeholder="Password" />
          </FormGroup>
          <FormGroup>
            <Label for="confirmPassword">Confirm Password</Label>
            <Input
              type="password"
              name="confirmPassword"
              id="confirmPassword"
              placeholder="Confirm Password"
              hidden={isLogin}
            />
          </FormGroup>
          <Button color="primary" type="submit">
            {isLogin ? 'Login' : 'Sign up'}
          </Button>
          <Button color="link" onClick={switchModeHandler}>
            Switch to {isLogin ? 'Sign up' : 'Login'}
          </Button>
        </Form>
      </Col>
    </Row>
  );
};

export default AuthPage;

