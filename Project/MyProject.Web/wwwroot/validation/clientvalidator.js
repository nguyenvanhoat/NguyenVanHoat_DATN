function Validator(options) {

    var formElement = document.querySelector(options.form);

    var selectorRules = {};

    function validate(inputElement, rule) {
        var errorMessage;

        var listRules = selectorRules[rule.Selector];

        for (var i = 0; i < listRules.length; ++i) {
            errorMessage = listRules[i](inputElement.value);
            if (errorMessage)
                break;
        }

        var errorElement = inputElement.parentElement.querySelector(options.errorSelector);
        if (errorMessage) {
            errorElement.classList.add('text-danger');
            errorElement.innerText = errorMessage;
        }
        else {
            errorElement.classList.remove('text-danger');
            errorElement.innerText = '';
        }
        return !errorMessage;
    }

    if (formElement) {
        var insertElement = document.querySelector(options.submitSelector);
        insertElement.onclick = function () {
            var isFormValid = true;

            options.rules.forEach(function (rule) {
                var inputElement = document.querySelector(rule.Selector);
                var isValid = validate(inputElement, rule);
                if (!isValid) {
                    isFormValid = false;
                }
            });

            if (isFormValid) {
                if (typeof options.onClick === 'function') {
                    var enableInputs = formElement.querySelectorAll('[name]');
                    var formValues = Array.from(enableInputs).reduce(function (values, input) {

                        switch (input.type) {
                            case 'radio':
                                values[input.name] = formElement.querySelector('input[name="' + input.name + '"]:checked').value;
                                break;
                            case 'checkbox':
                                if (input.matches(':checked')) {
                                    values[input.name] = true;
                                    // return values;
                                }
                                else {
                                    values[input.name] = false;
                                }
                                // if (!Array.isArray(values[input.name])) {
                                //     values[input.name] = [];
                                // }
                                // values[input.name].push(input.value);
                                break;
                            case 'file':
                                values[input.name] = input.files;
                                break;
                            default:
                                values[input.name] = input.value;
                        }

                        return values;
                    }, {});
                    options.onClick(formValues);
                }
            }
            else {
                options.onClick(false);
            }
        }

        options.rules.forEach(function (rule) {

            var inputElement = document.querySelector(rule.Selector);

            if (Array.isArray(selectorRules[rule.Selector])) {
                selectorRules[rule.Selector].push(rule.test);
            } else {
                selectorRules[rule.Selector] = [rule.test];
            }


            if (inputElement) {
                inputElement.onblur = function () {
                    validate(inputElement, rule);
                }

                inputElement.oninput = function () {
                    var errorElement = inputElement.parentElement.querySelector(options.errorSelector);
                    errorElement.classList.remove('invalid');
                    errorElement.innerText = '';
                }
            }
        })
    }
}

Validator.isRequired = function (selector, message) {
    return {
        Selector: selector,
        test: function (value) {
            return value ? undefined : message || "Không được để trống";
        }
    }
}

Validator.isEmail = function (selector, message) {
    return {
        Selector: selector,
        test: function (value) {
            var regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            return regex.test(value) ? undefined : message || 'Trường này phải là email';
        }
    }
}

Validator.lengthRequired = function (selector, min, max, message) {
    return {
        Selector: selector,
        test: function (value) {
            return (value.length >= min && value.length <= max) ? undefined : message || "Độ dài không hợp lệ";
        }
    }
}

Validator.isPassword = function (selector, message) {
    return {
        Selector: selector,
        test: function (value) {
            var regex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*]).{8,}$/;
            return regex.test(value) ? undefined : message || 'Mật khẩu chưa đủ mạnh';
        }
    }
}